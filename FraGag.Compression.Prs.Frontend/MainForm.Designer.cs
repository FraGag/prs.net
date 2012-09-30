namespace FraGag.Compression.PrsFrontend
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.modeGroupBox = new System.Windows.Forms.GroupBox();
            this.compressRadioButton = new System.Windows.Forms.RadioButton();
            this.decompressRadioButton = new System.Windows.Forms.RadioButton();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.sourceFileSelector = new FraGag.Compression.PrsFrontend.FileSelector();
            this.destinationFileSelector = new FraGag.Compression.PrsFrontend.FileSelector();
            this.modeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFileSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationFileSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // modeGroupBox
            // 
            this.modeGroupBox.Controls.Add(this.compressRadioButton);
            this.modeGroupBox.Controls.Add(this.decompressRadioButton);
            this.modeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.modeGroupBox.Name = "modeGroupBox";
            this.modeGroupBox.Size = new System.Drawing.Size(173, 43);
            this.modeGroupBox.TabIndex = 8;
            this.modeGroupBox.TabStop = false;
            this.modeGroupBox.Text = "Mode";
            // 
            // compressRadioButton
            // 
            this.compressRadioButton.AutoSize = true;
            this.compressRadioButton.Checked = true;
            this.compressRadioButton.Location = new System.Drawing.Point(6, 20);
            this.compressRadioButton.Name = "compressRadioButton";
            this.compressRadioButton.Size = new System.Drawing.Size(72, 17);
            this.compressRadioButton.TabIndex = 0;
            this.compressRadioButton.TabStop = true;
            this.compressRadioButton.Text = "&Compress";
            this.compressRadioButton.UseVisualStyleBackColor = true;
            // 
            // decompressRadioButton
            // 
            this.decompressRadioButton.AutoSize = true;
            this.decompressRadioButton.Location = new System.Drawing.Point(84, 20);
            this.decompressRadioButton.Name = "decompressRadioButton";
            this.decompressRadioButton.Size = new System.Drawing.Size(83, 17);
            this.decompressRadioButton.TabIndex = 1;
            this.decompressRadioButton.TabStop = true;
            this.decompressRadioButton.Text = "&Decompress";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(12, 66);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(44, 13);
            this.sourceLabel.TabIndex = 9;
            this.sourceLabel.Text = "&Source:";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(12, 96);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(65, 13);
            this.destinationLabel.TabIndex = 10;
            this.destinationLabel.Text = "&Destination:";
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Enabled = false;
            this.goButton.Location = new System.Drawing.Point(398, 61);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(74, 54);
            this.goButton.TabIndex = 11;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // sourceFileSelector
            // 
            this.sourceFileSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceFileSelector.DefaultExt = "";
            this.sourceFileSelector.FileName = "";
            this.sourceFileSelector.Filter = "";
            this.sourceFileSelector.Location = new System.Drawing.Point(87, 61);
            this.sourceFileSelector.Name = "sourceFileSelector";
            this.sourceFileSelector.Size = new System.Drawing.Size(305, 24);
            this.sourceFileSelector.TabIndex = 12;
            this.sourceFileSelector.FileNameChanged += new System.EventHandler(this.fileSelector_FileNameChanged);
            // 
            // destinationFileSelector
            // 
            this.destinationFileSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationFileSelector.DefaultExt = "";
            this.destinationFileSelector.FileName = "";
            this.destinationFileSelector.Filter = "";
            this.destinationFileSelector.Location = new System.Drawing.Point(87, 91);
            this.destinationFileSelector.Name = "destinationFileSelector";
            this.destinationFileSelector.Size = new System.Drawing.Size(305, 24);
            this.destinationFileSelector.TabIndex = 12;
            this.destinationFileSelector.FileNameChanged += new System.EventHandler(this.fileSelector_FileNameChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 127);
            this.Controls.Add(this.destinationFileSelector);
            this.Controls.Add(this.sourceFileSelector);
            this.Controls.Add(this.modeGroupBox);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.goButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "PRS compression/decompression utility";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.modeGroupBox.ResumeLayout(false);
            this.modeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFileSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationFileSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox modeGroupBox;
        private System.Windows.Forms.RadioButton compressRadioButton;
        private System.Windows.Forms.RadioButton decompressRadioButton;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Button goButton;
        private FileSelector sourceFileSelector;
        private FileSelector destinationFileSelector;

    }
}

