/*
The Caesar cipher is one of the earliest known and simplest ciphers. It is a type of substitution cipher in which each letter in the plaintext is shifted to a certain number of places down the alphabet. For example, with a shift of 1, A would be replaced by B, B would become C, and so on. The method is named after Julius Caesar, who allegedly used it to communicate with his generals.

Here is a quick example of the encryption and decryption steps involved with the Caesar cipher. The text we will encrypt is "defend the east wall of the castle," with a shift (key) of 1.

Plaintext: "defend the east wall of the castle"
Ciphertext: "efgfoe uif fbtu xbmm pg uif dbtumf"

It is easy to see how each character in the plaintext is shifted up the alphabet. Decryption is just as easy, by using an offset of -1.

-------------------------------------------------

Code written by Lucas Kliemczak

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Encryption
{
    class CaesarCipher
    {
        static void Main(string[] args)
        {
            string msg;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int key;

            Console.WriteLine("Enter the key:");
            key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(key);

            Console.WriteLine("Enter the message:");
            msg = Console.ReadLine();
            Console.WriteLine(msg);
            
            Console.WriteLine("\nThe encrypted message is: ");
            
            for(int i=0; i<msg.Length; i++){
                int count = 0;
                for(int j=0; j<alphabet.Length; j++){
                    if(alphabet[j] == msg[i]){
                        
                        Console.Write(alphabet[ (j+key)%(alphabet.Length-1) ]);
                        count++;
                        break;
                    }
                    if(ALPHABET[j] == msg[i]){
                        
                        Console.Write(ALPHABET[ (j+key)%(alphabet.Length-1) ]);
                        count++;
                        break;
                    }
                }
                if(count == 0){
                    Console.Write(msg[i]);
                }
            }
        }
    }
}
