using GrapeCity.Documents.Pdf;
using System;
using System.Collections.Generic;
using System.IO;

namespace DDImportFormDataFromCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DioDocs for PDF. PDF Form Data Import! (ImportFormDataFromCollection)");

            // PDFフォームへ入力するデータ
            var kvp = new KeyValuePair<string, IList<string>>[]
            {
                new KeyValuePair<string, IList<string>>("氏名", new string[] { "葡萄城　太郎" }),
                new KeyValuePair<string, IList<string>>("会社名", new string[] { "ディオドック株式会社" }),
                new KeyValuePair<string, IList<string>>("フリガナ", new string[] { "ブドウジョウ　タロウ" }),
                new KeyValuePair<string, IList<string>>("TEL", new string[] { "022-777-8888" }),
                new KeyValuePair<string, IList<string>>("部署名", new string[] { "ピノタージュ" }),
                new KeyValuePair<string, IList<string>>("住所", new string[] { "M県S市広瀬区花京院3-1-4" }),
                new KeyValuePair<string, IList<string>>("郵便番号", new string[] { "981-9999" }),
                new KeyValuePair<string, IList<string>>("Email", new string[] { "tarou.budojo@grapecity.com" })
            };

            var doc = new GcPdfDocument();

            // PDFを読み込み
            doc.Load(new FileStream("grapecity_order_template.pdf", FileMode.Open, FileAccess.Read));

            // KeyValuePairからデータを入力
            doc.ImportFormDataFromCollection(kvp);

            // PDFを保存
            doc.Save("grapecity_order_embed.pdf");
        }
    }
}
