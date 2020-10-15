using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace makeTrainTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start making the train.txt file");

            var listOfImages = Directory.GetFiles("C:\\Users\\cedri\\Documents\\ITProject\\files_training\\v2\\ttjkejftmo\\TrainingImages");

            List<string> listTrainTxt = new List<string>();
            List<string> listestTxt = new List<string>();

            for (int i = 1; i < listOfImages.Length; i++)
            {
                Console.WriteLine(listOfImages[i]);
                if (i % 10 == 0)
                {
                    listestTxt.Add(listOfImages[i]);
                }
                else
                {
                    listTrainTxt.Add(listOfImages[i]);
                }
            }

            using (StreamWriter writer =
                new StreamWriter("C:\\Users\\cedri\\Documents\\ITProject\\files_training\\v2\\ttjkejftmo\\train.txt"))
            {
                foreach (var image in listTrainTxt)
                {
                    //Console.WriteLine(image);
                    //Console.WriteLine(image.Substring(57));

                    writer.Write("data/obj/" + image.Substring(57) + "\n");
                }

                //C: \Users\cedri\Documents\ITProject\files_training\images\10019.png
            }

            using (StreamWriter writer =
                new StreamWriter("C:\\Users\\cedri\\Documents\\ITProject\\files_training\\v2\\ttjkejftmo\\test.txt"))
            {
                foreach (var image in listestTxt)
                {
                    //Console.WriteLine(image);
                    //Console.WriteLine(image.Substring(57));

                    writer.Write("data/obj/" + image.Substring(57) + "\n");
                }

                //C: \Users\cedri\Documents\ITProject\files_training\images\10019.png
            }
        }
    }
}