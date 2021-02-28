using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFile
{
    class FileOperation
    {
        FileInfo FileInfo { get; set; }
        string FileName { get; set; }

        public FileOperation() : this("") {
            this.FileInfo = new FileInfo(this.FileName);
        }
 
        public FileOperation(string fileName)
        {
            if (fileName != null)
            {
                this.FileName = fileName;
                try
                {
                    this.FileInfo = new FileInfo(this.FileName);
                    
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            else
            {
                this.FileName = "";
                this.FileInfo = new FileInfo(this.FileName);
            }           
        }


        //ファイルの有無を調べる
        public void dispJudge1()
        {
            if (File.Exists(this.FileName))
            {
                Console.WriteLine("すでにファイルは存在します");
            }
            Console.WriteLine("ファイルは存在しません");
        }

        public void dispJudge2()
        {            
            if (this.FileInfo.Exists)
            {
                Console.WriteLine("すでにファイルは存在します");
            }
            Console.WriteLine("ファイルは存在しません");
        }

        //ファイルの削除
        public void deleteFile1()
        {
            try
            {
                File.Delete(this.FileName);
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
            
        }

        public void deleteFile2()
        {
            try
            {
                this.FileInfo.Delete();
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
        }

        //ファイルのコピー
        public void fileCopy1(string destFileName)
        {
            try
            {
                File.Copy(this.FileName, destFileName);
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }   
        }

        public void fileCopy2(string destFileName)
        {
            try
            {
                this.FileInfo.CopyTo(destFileName);
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
        }

        //ファイルの移動,ファイル名の変更
        //パスが違うかつファイル名は同じ→移動
        //パスが同じかつファイル名は異なる→ファイル名の変更
        public void fileMove1(string destFileName)
        {
            try
            {
                File.Move(this.FileName,destFileName);
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public void fileMove2(string destFileName)
        {
            try{
                this.FileInfo.MoveTo(destFileName);
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
            
        }

        //ファイルの最終更新日/作成日時の取得・設定
        public void getLastTime1(bool update)
        {
            if (update)
            {
                try
                {
                    File.SetLastWriteTime(this.FileName, DateTime.Now);
                    var LastTime = File.GetLastWriteTime(this.FileName);
                    Console.WriteLine(LastTime.ToString());
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            else
            {
                try
                {
                    var LastTime = File.GetLastWriteTime(this.FileName);
                    Console.WriteLine(LastTime.ToString());
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine(error.Message);
                }
               
            }
        }

        public void getLastTime2(bool update)
        {
            if (update)
            {
                try
                {
                    this.FileInfo.LastWriteTime = DateTime.Now;
                    var LastTime = this.FileInfo.CreationTime;
                    Console.WriteLine(LastTime.ToString());

                }
                catch (IOException error)
                {
                    Console.WriteLine(error.Message);
                }

            }
            else
            {
                try
                {
                    var LastTime = this.FileInfo.CreationTime;
                    Console.WriteLine(LastTime.ToString());
                }
                catch (IOException error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

        public void getFileSize()
        {
            try
            {
                var FileSize = this.FileInfo.Length;
                Console.WriteLine(FileSize);
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);

            }
            
        }



    }
}
