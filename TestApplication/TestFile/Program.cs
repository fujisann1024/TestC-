using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextFileReader textFileReader = new TextFileReader();
            //textFile.dispText1();
            //textFile.dispText2();
            //textFile.dispText3();
            //textFile.dispText4();
            //textFile.dispText5();

            //TextFileWriter textFileWriter = new TextFileWriter();
            //textFileWriter.writeText("こんにちは");
            //textFileWriter.writeNextText("こんばんは");
            //textFileWriter.writeHeadText("おはよう");

            //List<string> texts = new List<string> { "東京","大阪","名古屋"};
            //textFileWriter.writeAllText(texts);

            var operation = new FileOperation();
            operation.dispJudge1("");
        }
    }
}
