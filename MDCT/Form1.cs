using System;
using System.Windows.Forms;
using System.IO;
using NWaves.Audio;
using NWaves.Signals;
using ATL;

namespace MDCT
{
    public partial class Form1 : Form
    {
        private int block = 2;
        private int ratio = 2;
        public string file_compress_dir = "//";
        private string file_decompress_dir = "//";
        public Form1()
        {
            InitializeComponent();
            block_textbox.Enabled = false;
            ratio_textbox.Enabled = false;
            file_compression.Enabled = false;
            compression_sampling.Enabled = false;
            file_decompress.Enabled = false;
            decompress_sampling.Enabled = false;
            decompress_block.Enabled = false;
            decompress_ratio.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (file_decompress_dir == "//")
                {
                    MessageBox.Show("Please open a File");
                    return;
                }
                mdct_class mdct = new mdct_class();
                DiscreteSignal left, right;
                using (var stream = new FileStream(file_decompress_dir, FileMode.Open))
                {
                    var waveFile = new WaveFile(stream);
                    left = waveFile[Channels.Left];
                    right = waveFile[Channels.Right];
                }
                Track track = new Track(file_decompress_dir);
                String block = null;
                String ratio = null;
                track.AdditionalFields.TryGetValue("N", out block);
                track.AdditionalFields.TryGetValue("M", out ratio);
                if(block == null || ratio == null)
                {
                    MessageBox.Show("The Audio is Not Compressed properly");
                    return;
                }
                progressBar2.Value = 50;
                int key = 0;
                key = mdct.decompression(left, right, Int16.Parse(block), Int16.Parse(ratio));
                if (key == 1)
                {
                    progressBar2.Value = 100;
                    MessageBox.Show("Action Complete");
                }
                else
                {
                    progressBar2.Value = 0;
                    MessageBox.Show("Action Abandoned");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            block++;
            block_textbox.Text = null;
            block_textbox.Text = " " + block.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (block == 2)
                return;
            block--;
            block_textbox.Text = null;
            block_textbox.Text = " " + block.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ratio == -2)
                ratio = 1;
            ratio++;
            ratio_textbox.Text = null;
            ratio_textbox.Text = " " + ratio.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ratio == 2)
                ratio = -1;
            ratio--;
            ratio_textbox.Text = null;
            ratio_textbox.Text = " " + ratio.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            file_compress_dir = open_function();
            update_textbox(file_compress_dir, true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            progressBar2.Value = 0;
            file_decompress_dir = open_function();
            update_textbox(file_decompress_dir, false);
        }

        private string open_function()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Wave File (*.wav)|*.wav;";
            if (open.ShowDialog() != DialogResult.OK) return null;
            return open.FileName;
        }
        private void update_textbox(string file_name, bool compression_check)
        {
            if(compression_check)
            {
                Track track = new Track(file_name);
                file_compression.Text = file_name;
                compression_sampling.Text = track.SampleRate.ToString();
            }
            else
            {
                Track track = new Track(file_name);
                String block;
                String ratio;
                file_decompress.Text = file_name;
                decompress_sampling.Text = track.SampleRate.ToString();
                track.AdditionalFields.TryGetValue("N", out block);
                track.AdditionalFields.TryGetValue("M", out ratio);
                decompress_block.Text = block;
                decompress_ratio.Text = ratio;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(file_compress_dir == "//")
            {
                MessageBox.Show("Please open a File");
                return;
            }
            mdct_class mdct = new mdct_class();
            DiscreteSignal left, right;
            try
            {
                using (var stream = new FileStream(file_compress_dir, FileMode.Open))
                {
                    var waveFile = new WaveFile(stream);
                    left = waveFile[Channels.Left];
                    right = waveFile[Channels.Right];
                }
            }
            catch
            {
                MessageBox.Show("Error Reading Channels from Audio File");
                return;
            }
            int key = 0;
            progressBar1.Value = 50;
            key = mdct.compression(left, right, Int16.Parse(block_textbox.Text), Int16.Parse(ratio_textbox.Text));
            if(key == -1)
            {
                progressBar1.Value = 0;
                MessageBox.Show("Action Abandoned");
                return;
            }
            progressBar1.Value = 100;
            MessageBox.Show("Action Complete");
        }
    }
}
