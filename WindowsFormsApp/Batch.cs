using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp
{
   public class Batch
    {
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Location { get; set; }
        public static string TrainerName { get; set; }

    }
    class StoreBatchInfo
    {
        static void Main(string[] args)
        {
            FileStream fs;
            Batch batch = new Batch() { BatchId = 001, BatchName = "C#", StartDate = "21/3/2022", EndDate = "30/5/2022", Location = "Pune" };
            string path = @"D:\New Test\Batch Binary write_Read";
            try
            {
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder Already Exists");

                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                fs = new FileStream(@"D:\New Test\Batch Binary write_Read\BatchBinary1", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(batch.BatchId));
                bw.Write(batch.BatchName);
                bw.Write(batch.StartDate);
                bw.Write(batch.EndDate);
                bw.Write(batch.Location);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
            //Binary Read
            try
            {
                fs = new FileStream(@"D:\New Test\Batch Binary write_Read\BatchBinary1", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                MessageBox.Show($"Batch Id={br.ReadInt32().ToString()}\nBatch Name={br.ReadString()}\nBatch Start Date={br.ReadString()}\nBatch End Date={br.ReadString()}\nBatch Location={br.ReadString()}");
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
