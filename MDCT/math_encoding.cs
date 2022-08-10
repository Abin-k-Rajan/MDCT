using System;

namespace MDCT
{
    class math_encoding
    {
        public float[] compress_left(float[] left, float[] right, int N, long Len)
        {
            float[] left_new = new float[left.Length];
            for(long i=0; i<left.Length; i++)
            {
                left_new[i] = (left[i] + right[i]) / 2;
            }
            left_new = form_blocks(left_new, N);
            left_new = window_function(N, left_new);
            left_new = mdct_compression(N, left_new, Len);
            return left_new;
        }
        public float[] compress_right(float[] left, float[] right, int N, long Len)
        {
            float[] right_new = new float[right.Length];
            for (long i = 0; i < right.Length; i++)
            {
                right_new[i] = (left[i] - right[i]) / 2;
            }
            right_new = form_blocks(right_new, N);
            right_new = window_function(N, right_new);
            right_new = mdct_compression(N, right_new, Len);
            return right_new;
        }
        public float[] decompress(float[] left, int N)
        {
            left = mdct_decompression(left, N);
            left = window_function(N, left);
            left = remove_blocks(N, left);
            return left;
        }
        public float[] inv_pre_left(float[] left, float[] right)
        {
            float[] left_new = new float[left.Length];
            for(long i=0; i<left.Length; i++)
            {
                left_new[i] = (left[i] + right[i]);
            }
            return left_new;
        }//L = M + S
        public float[] inv_pre_right(float[] left, float[] right)
        {
            float[] right_new = new float[right.Length];
            for (long i = 0; i < right.Length; i++)
            {
                right_new[i] = (left[i] - right[i]);
            }
            return right_new;
        }//R = M - S
        private float[] window_function(int N, float[] xn)
        {
            float[] final = new float[xn.Length];
            double Wn;
            double angle;
            for(int n=0; n<xn.Length; n++)
            {
                angle = ((Math.PI) / (2 * N)) * (n + 0.5);
                Wn = Math.Sin(angle) * xn[n];
                final[n] = (float)Wn;
            }
            return final;
        }

        private float[] mdct_compression(int N, float[] xn, long Len)
        {
            double mdct;
            double angle;
            double temp;
            long place = 0;
            float[] final = new float[(xn.Length/2)];
            for(long i = 0; i<xn.Length; i+=2*N)
            for(long k = 0; k<N; k++)
            {
                mdct = 0;
                 temp= 0;
                for(long n=0; n<2*N && n+i < xn.Length; n++)
                {
                    angle = (Math.PI / N * (n + 0.5 * (1 +  N)) * (k + 0.5));
                    temp = Math.Cos(angle)*xn[n+i];
                    mdct += temp;
                }
                if (place >= Len)
                     return final;
                if (place >= xn.Length / 2)
                     break;
                final[place++] = (float)mdct;
            }
            return final;
        }
        private float[] form_blocks(float[] xn, int M)
        {
            float[] block = new float[2*xn.Length + 2*M];
            int j = 0;
            for(int i=0; i<M; i++)
            {
                block[i] = 0;
            }
            for(long i=M; i<2 * xn.Length; i++)
            {
                if (i == (2 * xn.Length))
                {
                    return block;
                }
                if (i % (2*M) == 0)
                {
                    i += (M-1);
                }
                else
                {
                    block[i] = block[i + M] = xn[j++];
                }
            }
            return block;
        }
        private float[] mdct_decompression(float[] Xn, int N)
        {
            double mdct;
            double angle;
            double temp;
            long place = 0;
            float[] final = new float[(2 * Xn.Length)];
            for(int i=0; i<Xn.Length; i+=N)
                for(int n=0; n < 2 * N; n++)
                {
                    mdct = 0;
                    temp = 0;
                    for (int k = 0; k < N && k + i < Xn.Length; k++)
                    {
                        angle = (Math.PI / N * (n + 0.5 * (1 + N)) * (k + 0.5));
                        temp = Math.Cos(angle) *  Xn[k + i];
                        mdct += temp;
                    }
                    mdct = mdct * 2 / N;
                    if (place == Xn.Length * 2)
                        break;
                    final[place++] = (float)mdct;
                }
            return final;
        }

        private float[] remove_blocks(int N, float[] Xn)
        {
            float[] final = new float[(Xn.Length/2)];
            long place = 0;
            for(int i = 0; i < N; i++)
            {
                Xn[i] = 0;
                Xn[Xn.Length - i - 1] = 0;
            }
            for (long i = N; i < Xn.Length; i++)
            {
                if (i % (2 * N) == 0)
                {
                    i += N;
                }
                if ((N + i) >= Xn.Length)
                {
                    return final;
                }
                else
                {
                    final[place++] = (Xn[i]+Xn[N+i]);
                }
            }
            return final;
        }

        public float[] compression_factor(float[] Xn, int M, int N)
        {
            long length = Xn.Length % N + (N - M) * Xn.Length / N;
            int m = (N - M);
            int j = 0;
            long k = 0;
            float[] final = new float[length];
            for(long i=0; i<Xn.Length && j<length; i++)
            {
                final[j++] = Xn[i];
                m--;
                if(m <= 0)
                {
                    i += M;
                    m = (N -M);
                }
                k = i;
            }
            Console.WriteLine(Xn.Length - k);
            return final;
        }
        public float[] decompression_factor(float[] Xn, int M ,int N)
        {
            long length = Xn.Length + M * Xn.Length/(N-M);
            int m = (N - M);
            int j = 0;
            float[] final = new float[length];
            for (long i = 0; i < Xn.Length && j < length; i++)
            {
                final[j++] = Xn[i];
                m--;
                if (m <= 0 && j < length)
                {
                    for(int k=0; k<M && j<length; k++)
                        final[j++] = 0;
                    m = (N - M);
                }
            }
            return final;
        }
    }
}
