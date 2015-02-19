﻿using System;
using System.Drawing;
using System.Linq;
using Novacode;

namespace WordDocumentGeneratorApp
{
    public class SoftUniSandbox
    {
        public static void CreateDocument()
        {
            string headerText = "SoftUni OOP Game Contest";
            string contentText = "SoftUni is organizing a contest for the best role playing game from the OOP teamwork projects." +
                                 " The winning teams will receive a grand prize!" +
                                 " The game should be:";
            string[] bullets =
            {
                "Properly structured and follow all good OOP practices",
                "Awesome",
                "..Very Awesome"
            };

            string[] tableHeaders =
            {
                "Team", "Game", "Points"
            };

            string preFooter = "The top 3 teams will receive a SPECTACULAR prize:";
            string footer = "A HANDSHAKE FROM NAKOV";

            var doc = DocX.Create("../../SoftUniGenerator.docx");

            var titleFormat = new Formatting();
            titleFormat.FontFamily = new System.Drawing.FontFamily("Arial");
            titleFormat.Size = 24D;
            titleFormat.Position = 22;

            var contentFormat = new Formatting();
            contentFormat.FontFamily = new System.Drawing.FontFamily("Arial");
            contentFormat.Size = 8D;
            contentFormat.Position = 12;

            var bulletedList = doc.AddList(bullets[0], 0, ListItemType.Bulleted);

            doc.AddListItem(bulletedList, bullets[1]);
            doc.AddListItem(bulletedList, bullets[2]);

            Paragraph title = doc.InsertParagraph(headerText, false, titleFormat);
            title.Alignment = Alignment.center;

            Novacode.Image img = doc.AddImage(@"../../resources/rpg-game.png");

            Paragraph p = doc.InsertParagraph("", false);

            Picture pic = img.CreatePicture();

            pic.Height = 250;
            pic.Width = 500;

            p.AppendPicture(pic);

            p.InsertParagraphAfterSelf("", false);
            p.Alignment = Alignment.center;
            p.Position(0);

            doc.InsertParagraph(Environment.NewLine);

            Paragraph letterBody = doc.InsertParagraph(contentText, false, contentFormat);
            letterBody.Alignment = Alignment.both;

            doc.InsertParagraph("", false);

            doc.InsertList(bulletedList);

            doc.InsertParagraph(Environment.NewLine);

            Table t = doc.AddTable(4, 3);

            for (int i = 0; i < t.ColumnCount; i++)
            {
                t.Rows[0].Cells[i].Paragraphs.First().Append(tableHeaders[i])
                .Color(Color.White).Alignment = Alignment.center;
            }

            for (int i = 1; i < t.RowCount; i++)
            {
                for (int j = 0; j < t.ColumnCount; j++)
                {
                    t.Rows[i].Cells[j].Paragraphs.First().Append("-").Alignment = Alignment.center;
                }
            }

            t.Alignment = Alignment.center;
            t.Design = TableDesign.ColorfulGridAccent1;

            doc.InsertTable(t);

            doc.InsertParagraph(Environment.NewLine);

            Paragraph footer1 = doc.InsertParagraph(preFooter, false);

            footer1.InsertParagraphAfterSelf(footer)
                .Bold()
                .FontSize(24)
                .UnderlineStyle(UnderlineStyle.singleLine)
                .Color(Color.DarkSlateBlue)
                .Alignment = Alignment.center;
            footer1.Alignment = Alignment.center;

            doc.SaveAs("../../SoftUniGenerator.docx");
        }
    }
}
