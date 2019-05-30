using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antenna
{
    class Gamma
    {
        static private string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя 0123456789";
        static private int k, x, z;
        static private string res;

        static public string Encryption(string source, string key)
        {
            res = string.Empty;

            while (key.Length < source.Length)
            {
                key += key;
                if (key.Length > source.Length) key = key.Remove(source.Length);
            }
            for (int i = 0; i < source.Length; i++)
            {
                for (int id = 0; id < alf.Length; id++)
                {
                    if (key[i] == alf[id]) k = id;
                    if (source[i] == alf[id]) x = id;
                    z = (x + k) % alf.Length;
                }
                res += alf[z];
            }
            return res;
        }

        static public string Decryption(string source, string key)
        {
            res = string.Empty;

            while (key.Length < source.Length)
            {
                key += key;
                if (key.Length > source.Length) key = key.Remove(source.Length);
            }
            for (int i = 0; i < source.Length; i++)
            {
                for (int id = 0; id < alf.Length; id++)
                {
                    if (key[i] == alf[id]) k = id;
                    if (source[i] == alf[id]) x = id;
                    z = ((source[i] - key[i]) + alf.Length) % alf.Length;
                }
                res += alf[z];
            }
            return res;
        }
    }
}
}
