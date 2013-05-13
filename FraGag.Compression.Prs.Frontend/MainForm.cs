// Copyright (c) 2012, 2013, Francis Gagné
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
//     * Redistributions of source code must retain the above copyright
//       notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright
//       notice, this list of conditions and the following disclaimer in the
//       documentation and/or other materials provided with the distribution.
//     * Neither the name of the <organization> nor the
//       names of its contributors may be used to endorse or promote products
//       derived from this software without specific prior written permission.

namespace FraGag.Compression.PrsFrontend
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private static readonly string CompressErrorMessageHeader = "An error occurred.";
        private static readonly string DecompressErrorMessageHeader = "An error occurred. Make sure the source file you selected is a PRS compressed file.";

        public MainForm()
        {
            this.InitializeComponent();
            this.LoadSettings();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.SaveSettings();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            this.SaveSettings();

            try
            {
                this.Execute();
            }
            catch (Exception ex)
            {
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    throw;
                }

                string header = this.decompressRadioButton.Checked ? DecompressErrorMessageHeader : CompressErrorMessageHeader;
                MessageBox.Show(this, header + Environment.NewLine + Environment.NewLine + ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void compressRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.sourceFileSelector.Filter = "All Files (*.*)|*.*";
            this.destinationFileSelector.Filter = "PRS Files (*.prs)|*.prs";
        }

        private void decompressRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.sourceFileSelector.Filter = "PRS Files (*.prs)|*.prs";
            this.destinationFileSelector.Filter = "All Files (*.*)|*.*";
        }

        private void fileSelector_FileNameChanged(object sender, EventArgs e)
        {
            this.SetGoButtonEnabled();
        }

        private void LoadSettings()
        {
            Properties.Settings settings = Properties.Settings.Default;
            this.compressRadioButton.Checked = settings.Mode == 0;
            this.decompressRadioButton.Checked = settings.Mode == 1;
            this.sourceFileSelector.FileName = settings.SourceFilePath;
            this.destinationFileSelector.FileName = settings.DestinationFilePath;
        }

        private void SaveSettings()
        {
            Properties.Settings settings = Properties.Settings.Default;
            if (this.compressRadioButton.Checked)
            {
                settings.Mode = 0;
            }
            else if (this.decompressRadioButton.Checked)
            {
                settings.Mode = 1;
            }

            settings.SourceFilePath = this.sourceFileSelector.FileName;
            settings.DestinationFilePath = this.destinationFileSelector.FileName;
            settings.Save();
        }

        private void SetGoButtonEnabled()
        {
            this.goButton.Enabled =
                !string.IsNullOrEmpty(this.sourceFileSelector.FileName) &&
                !string.IsNullOrEmpty(this.destinationFileSelector.FileName);
        }

        private void Execute()
        {
            if (this.compressRadioButton.Checked)
            {
                Prs.Compress(this.sourceFileSelector.FileName, this.destinationFileSelector.FileName);
            }
            else if (this.decompressRadioButton.Checked)
            {
                Prs.Decompress(this.sourceFileSelector.FileName, this.destinationFileSelector.FileName);
            }
        }
    }
}
