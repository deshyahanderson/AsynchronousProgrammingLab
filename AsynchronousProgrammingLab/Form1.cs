using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AsynchronousProgrammingLab
{
    public partial class Form1 : Form
    {
        private string file1Path = string.Empty;
        private string file2Path = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        // Author: Deshyah Anderson
        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Select Book 1";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file1Path = openFileDialog.FileName;
                    txtFile1.Text = openFileDialog.SafeFileName;
                }
            }
        }

        // Author: Deshyah Anderson
        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Select Book 2";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file2Path = openFileDialog.FileName;
                    txtFile2.Text = openFileDialog.SafeFileName;
                }
            }
        }

        // Author: Deshyah Anderson
        private async Task<List<string>> GetTopWordsAsync(string filePath)
        {
            string content = await File.ReadAllTextAsync(filePath);

            return await Task.Run(() =>
            {
                MatchCollection matches = Regex.Matches(content.ToLower(), @"\b[a-z]+\b");

                return matches
                    .Cast<Match>()
                    .Select(m => m.Value)
                    .GroupBy(word => word)
                    .OrderByDescending(group => group.Count())
                    .Take(10)
                    .Select(group => $"{group.Key} - {group.Count()}")
                    .ToList();
            });
        }

        // Author: Deshyah Anderson
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(file1Path) || !File.Exists(file1Path))
            {
                MessageBox.Show("Please browse and choose Book 1 first.", "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(file2Path) || !File.Exists(file2Path))
            {
                MessageBox.Show("Please browse and choose Book 2 first.", "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSubmit.Enabled = false;
            lstBook1.Items.Clear();
            lstBook2.Items.Clear();

            try
            {
                Task<List<string>> task1 = GetTopWordsAsync(file1Path);
                Task<List<string>> task2 = GetTopWordsAsync(file2Path);

                await Task.WhenAll(task1, task2);

                foreach (string entry in await task1)
                {
                    lstBook1.Items.Add(entry);
                }

                foreach (string entry in await task2)
                {
                    lstBook2.Items.Add(entry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSubmit.Enabled = true;
            }
        }

        // Author: Deshyah Anderson
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
