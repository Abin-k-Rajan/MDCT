using System;
using System.IO;
using System.Linq;
using ATL;
using System.Windows.Forms;
using NWaves.Audio;
using NWaves.Signals;

namespace MDCT
{
    class mdct_class
    {
        math_encoding math_enc = new math_encoding();
        public int compression(DiscreteSignal left, DiscreteSignal right, int N, int M)
        {
            try
            {
                string _dir = get_directory();
                float[] left_float = new float[left.Length];
                float[] right_float = new float[right.Length];
                left_float = left.First(left.Length).Samples;
                right_float = right.First(right.Length).Samples;
                float[] left_new = new float[left.Length];
                float[] right_new = new float[right.Length];
                left_new = math_enc.compress_left(left_float, right_float, N, left_float.Length);
                right_new = math_enc.compress_right(left_float, right_float, N, left_float.Length);
                for (long i = 0; i < left_new.Length; i++)
                {
                    left_new[i] = left_new[i] / 100;
                    right_new[i] = right_new[i] / 100;
                    if (left_new[i] > 1f || right_new[i] > 1f || left_new[i] < -1f || right_new[i] < -1f)
                    {
                        MessageBox.Show("Action Aborted because of Audio Distortion. Consider increasing the Ratio");
                        return 0;
                    }
                }
                left_new = math_enc.compression_factor(left_new, M, N);
                right_new = math_enc.compression_factor(right_new, M, N);
                mdct_transform(left_new, right_new, left.SamplingRate, true, N, M, _dir);
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
            
        }

        public int decompression(DiscreteSignal left, DiscreteSignal right, int N, int M)
        {
            try
            {
                string _dir = get_directory();
                float[] left_float = new float[left.Length];
                float[] right_float = new float[right.Length];
                left_float = left.First(left.Length).Samples;
                right_float = right.First(right.Length).Samples;
                float[] left_new = new float[left.Length];
                float[] right_new = new float[right.Length];
                left_float = math_enc.decompression_factor(left_float, M, N);
                right_float = math_enc.decompression_factor(right_float, M, N);
                left_float = math_enc.decompress(left_float, N);
                right_float = math_enc.decompress(right_float, N);
                left_new = math_enc.inv_pre_left(left_float, right_float);
                right_new = math_enc.inv_pre_right(left_float, right_float);
                for (long i = 0; i < left_new.Length; i++)
                {
                    left_new[i] = left_new[i] * 100;
                    right_new[i] = right_new[i] * 100;
                }
                mdct_transform(left_new, right_new, left.SamplingRate, false, N, M, _dir);
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        private string get_directory()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Wave File (*.wav)|*.wav;";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return null;
            return saveFileDialog1.FileName;
        }

        private void mdct_transform(float[] samples_left, float[] smaples_right, int sampling_rate, bool compression_check, int N, int M, string file_name)
        {
            DiscreteSignal left = new DiscreteSignal(sampling_rate, samples_left, true);
            DiscreteSignal right = new DiscreteSignal(sampling_rate, smaples_right, true);
            if (compression_check)
            {
                using (var stream = new FileStream(file_name, FileMode.Create))
                {
                    var waveFile = new WaveFile(new[] {left, right }, 16);
                    waveFile.SaveTo(stream);
                }
                Track track = new Track(file_name);
                track.AdditionalFields["N"] = N.ToString();
                track.AdditionalFields["M"] = M.ToString();
                track.Save();
            }
            else
            {
                using (var stream = new FileStream(file_name, FileMode.Create))
                {
                    var waveFile = new WaveFile(new[] { left, right }, 16);
                    waveFile.SaveTo(stream);
                }
            }
        }
    }
}
