namespace gasolina10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gasolina = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Litrosx100km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Galonxkm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costoxkm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btniniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gasolina)).BeginInit();
            this.SuspendLayout();
            // 
            // gasolina
            // 
            this.gasolina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gasolina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Litrosx100km,
            this.Galonxkm,
            this.Costoxkm});
            this.gasolina.Location = new System.Drawing.Point(122, 74);
            this.gasolina.Name = "gasolina";
            this.gasolina.RowTemplate.Height = 25;
            this.gasolina.Size = new System.Drawing.Size(442, 277);
            this.gasolina.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            // 
            // Litrosx100km
            // 
            this.Litrosx100km.HeaderText = "Litrosx100km";
            this.Litrosx100km.Name = "Litrosx100km";
            // 
            // Galonxkm
            // 
            this.Galonxkm.HeaderText = "Galonxkm";
            this.Galonxkm.Name = "Galonxkm";
            // 
            // Costoxkm
            // 
            this.Costoxkm.HeaderText = "Costoxkm";
            this.Costoxkm.Name = "Costoxkm";
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(625, 287);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(75, 64);
            this.btniniciar.TabIndex = 1;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.gasolina);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gasolina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gasolina;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Litrosx100km;
        private DataGridViewTextBoxColumn Galonxkm;
        private DataGridViewTextBoxColumn Costoxkm;
        private Button btniniciar;
    }
}