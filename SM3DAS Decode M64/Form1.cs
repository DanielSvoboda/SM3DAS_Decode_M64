using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SM3DAS_Decode_M64
{
    public partial class Form1 : Form
    {
        private string filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Decode_Click(object sender, EventArgs e)
        {
            // Permitir que o usuário escolha o arquivo Messages.bin
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Messages.bin (*.bin)|*.bin|All files (*.*)|*.*";
                openFileDialog.Title = "Select file Messages.bin";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    DecodeFile(filePath);
                }
            }
        }

        private void DecodeFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found.");
                return;
            }

            try
            {
                byte[] fileData = File.ReadAllBytes(filePath);

                int startAddress = 0x000009B0;

                if (fileData.Length <= startAddress)
                {
                    MessageBox.Show("The file is smaller than the starting address.");
                    return;
                }

                string decodedText = "";

                for (int i = startAddress; i < fileData.Length; i++)
                {
                    byte modifiedByte = (byte)(fileData[i] + 61);


                    // Simbolos:    ! " # $ % & ' ( ) * + , - . /
                    if (modifiedByte >= 32 && modifiedByte <= 47)
                    {
                        modifiedByte = (byte)(modifiedByte - 14);
                    }

                    // Letras maiúsculas:   @ (A-Z) [ \ ] ^ _ `
                    if (modifiedByte >= 64 && modifiedByte <= 96)
                    {
                        modifiedByte = (byte)(modifiedByte - 6);
                    }



                    if (modifiedByte == 219)
                    {
                        decodedText += ' ';
                    }

                    // Numeros de 0 a 9
                    //if (modifiedByte >= 48 && modifiedByte <= 57)
                    //{
                    //    modifiedByte = (byte)(modifiedByte - 7);
                    //}
                    //else if (modifiedByte == 55)
                    //{
                    //    decodedText += '0';
                    //}
                    //else if (modifiedByte == 56)
                    //{
                    //    decodedText += '1';
                    //}
                    //else if (modifiedByte == 57)
                    //{
                    //    decodedText += '2';
                    //}
                    //else if (modifiedByte == 58)
                    //{
                    //    decodedText += '3';
                    //}
                    //else if (modifiedByte == 59)
                    //{
                    //    decodedText += '4';
                    //}
                    //else if (modifiedByte == 60)
                    //{
                    //    decodedText += '5';
                    //}
                    //else if (modifiedByte == 61)
                    //{
                    //    decodedText += '6';
                    //}
                    //else if (modifiedByte == 62)
                    //{
                    //    decodedText += '7';
                    //}

                    else if (modifiedByte == 62)
                    {
                        decodedText += "15";
                    }
                    else if (modifiedByte == 63)
                    {
                        decodedText += '8';
                    }

                    else if (modifiedByte == 220)
                    {
                        decodedText += '-';
                    }
                    else if (modifiedByte == 172)
                    {
                        decodedText += ',';
                    }

                    else if (modifiedByte == 124)
                    {
                        decodedText += '.';
                    }

                    else if (modifiedByte == 123)
                    {
                        decodedText += '\'';
                    }



                    //if (modifiedByte >= 32 && modifiedByte <= 63)
                    //{
                    //    modifiedByte = (byte)(modifiedByte - 14);
                    //}


                    else if (modifiedByte == 59)
                    {
                        decodedText += "\\n";
                    }
                    else if (modifiedByte == 60) // End of text block
                    {
                        decodedText += Environment.NewLine;
                    }

                    else if (modifiedByte == 20)
                    {
                        decodedText += '&';
                    }
                    else if (modifiedByte == 21)
                    {
                        decodedText += ':';
                    }


                    // Sinais de controle (não-imprimíveis)
                    else if (modifiedByte == 13)
                    {
                        decodedText += "\\r";
                    }

                    // Caracteres legíveis
                    else if ((modifiedByte >= 32 && modifiedByte <= 126) || modifiedByte == 219 || modifiedByte == 20 || modifiedByte == 21 || modifiedByte == 13)
                    {
                        decodedText += (char)modifiedByte;
                    }
                    else
                    {
                        decodedText += "'" + modifiedByte + "'";
                    }
                }

                // Exibir o resultado na TextBox
                textBox1.Text = decodedText.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing file: " + ex.Message);
            }
        }
    }
}
