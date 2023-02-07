using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorWinform
{
    internal class RandomPasswordGenerator
    {
        public static string Generate(PasswordOptions options)
        {
            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numberChars = "0123456789";
            const string specialChars = "!@#$%^&/=*\\";
            const string bracketChars = "[]{}()<>";

            var allChars = "";

            var positions = new List<char>();

            if (options.UseLowercase)
            {
                allChars += lowercaseChars;

                positions.Add('l');

            }

            if (options.UseUppercase)
            {
                allChars += uppercaseChars;

                positions.Add('u');

            }

            if (options.UseNumbers)
            {
                allChars += numberChars;

                positions.Add('n');

            }

            if (options.UseSpecial)
            {
                allChars += specialChars;

                positions.Add('s');

            }

            if (!string.IsNullOrEmpty(options.CustomChars))
            {
                allChars += options.CustomChars;

                positions.Add('c');
            }

            if (options.UseMinus)
            {
                allChars += '-';

                positions.Add('m');
            }

            if (options.UseUnderline)
            {
                allChars += '_';

                positions.Add('e');
            }

            if (options.UseBrackets)
            {
                allChars += bracketChars;

                positions.Add('b');
            }

            if (options.UseSpace)
            {
                allChars += ' ';

                positions.Add('p');
            }

            while (positions.Count < options.Length)
            {
                positions.Add('a');
            }

            var rnd = new CryptoRandom();

            ShuffleList(rnd, positions);

            var password = "";

            for (var i = 0; i < positions.Count; i++)
            {
                string positionChars = null;
                switch (positions[i])
                {
                    case 'l':
                        positionChars = lowercaseChars;
                        break;

                    case 'u':
                        positionChars = uppercaseChars;
                        break;

                    case 'n':
                        positionChars = numberChars;
                        break;

                    case 's':
                        positionChars = specialChars;
                        break;
                    case 'c':
                        positionChars = options.CustomChars;
                        break;
                    case 'm':
                        positionChars = '-'.ToString();
                        break;
                    case 'e':
                        positionChars = '_'.ToString();
                        break;
                    case 'b':
                        positionChars = bracketChars;
                        break;
                    case 'p':
                        positionChars = ' '.ToString();
                        break;

                    case 'a':
                        positionChars = allChars;
                        break;

                    default:
                        break;
                }

                var randomCharIndex = rnd.Next(0, positionChars.Length - 1);
                var randomChar = positionChars[randomCharIndex];

                // no consecutive characters in a row
                if (options.NoRepeat)
                {
                    if (i > 0 && password[i - 1] == randomChar)
                    {
                        i--;
                        continue;
                    }
                }


                password += randomChar;
            }

            return password;
        }

        private static void ShuffleList<T>(Random rnd, List<T> list)
        {
            var length = list.Count - 1;
            while (length > 0)
            {
                var i = rnd.Next(0, length);

                (list[i], list[length]) = (list[length], list[i]);

                length--;
            }
        }
    }
}

    public class PasswordOptions
    {
        public bool UseLowercase { get; set; }

        public bool UseUppercase { get; set; }

        public bool UseNumbers { get; set; }

        public bool UseSpecial { get; set; }

        public bool UseBrackets { get; set; }

        public bool NoRepeat { get; set; }
        public bool UseSpace { get; set; }
        public bool UseMinus { get; set; }
        public bool UseUnderline { get; set; }

        public string? CustomChars { get; set; }

        public int Length { get; set; }
    }

    // Copied from https://docs.microsoft.com/en-us/archive/msdn-magazine/2007/september/net-matters-tales-from-the-cryptorandom
    public class CryptoRandom : Random
    {
        private RNGCryptoServiceProvider _rng = new RNGCryptoServiceProvider();
        private byte[] _uint32Buffer = new byte[4];

        public CryptoRandom()
        {
        }

        public CryptoRandom(int ignoredSeed)
        {
        }

        public override int Next()
        {
            _rng.GetBytes(_uint32Buffer);

            return BitConverter.ToInt32(_uint32Buffer, 0) & 0x7FFFFFFF;
        }

        public override int Next(int maxValue)
        {
            if (maxValue < 0) throw new ArgumentOutOfRangeException(nameof(maxValue));

            return Next(0, maxValue);
        }

        public override int Next(int minValue, int maxValue)
        {
            if (minValue > maxValue) throw new ArgumentOutOfRangeException(nameof(minValue));
            if (minValue == maxValue) return minValue;

            var diff = maxValue - minValue;

            while (true)
            {
                _rng.GetBytes(_uint32Buffer);

                var rand = BitConverter.ToUInt32(_uint32Buffer, 0);

                var max = 1 + (long)uint.MaxValue;
                var remainder = max % diff;

                if (rand < max - remainder)
                {
                    return (int)(minValue + (rand % diff));
                }
            }
        }

        public override double NextDouble()
        {
            _rng.GetBytes(_uint32Buffer);

            var rand = BitConverter.ToUInt32(_uint32Buffer, 0);

            return rand / (1.0 + uint.MaxValue);
        }

        public override void NextBytes(byte[] buffer)
        {
            if (buffer is null) throw new ArgumentNullException(nameof(buffer));

            _rng.GetBytes(buffer);
        }
    }