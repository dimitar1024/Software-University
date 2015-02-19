import java.io.FileOutputStream;
import java.io.IOException;
 
import com.itextpdf.text.BaseColor;
import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.Element;
import com.itextpdf.text.Font;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.Rectangle;
import com.itextpdf.text.pdf.BaseFont;
import com.itextpdf.text.pdf.PdfPCell;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;


public class _9_GenerateAPDFByExternalLibrary {

	public static void main(String[] args) 
		throws DocumentException, IOException {
	
	Document document = new Document();
	FileOutputStream file = new FileOutputStream("Deck-of-cards.pdf");
	PdfWriter.getInstance(document, file);
	
	String cards[] = new String[] {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
	String suit[] = new String[] {"\u2660", "\u2663", "\u2665","\u2666"};
	
	BaseFont baceFont = BaseFont.createFont("Arial.ttf", BaseFont.IDENTITY_H, true);
	Font blackFont = new Font(baceFont, 20f, 0, BaseColor.BLACK);
	Font redFont = new Font(baceFont, 20f, 0, BaseColor.RED);
	
	document.open();
	
	PdfPTable table = new PdfPTable(7);
	
	for (int i = 0; i < cards.length; i++) {
		for (int j = 0; j < suit.length; j++) {
			PdfPCell cell = new PdfPCell();
			cell.setPadding(3);
			cell.setBorder(Rectangle.NO_BORDER);
			
			PdfPTable singleCellTable = new PdfPTable(1);
			PdfPCell singleCell;
			
			if (j==0 || j==1) {
				singleCell = new PdfPCell(new Paragraph((cards[i]+suit[j]), blackFont));
			}
			else {
				singleCell = new PdfPCell(new Paragraph((cards[i]+suit[j]), redFont));
			}
			
			singleCell.setFixedHeight(60f);
			singleCell.setHorizontalAlignment(Element.ALIGN_CENTER);
			singleCell.setVerticalAlignment(Element.ALIGN_MIDDLE);
			singleCellTable.addCell(singleCell);
			cell.addElement(singleCellTable);
			
			table.addCell(cell);
		}
	}
	
		for (int i = 0; i < 4; i++) {
			PdfPCell emptyCell = new PdfPCell();
			emptyCell.setBorder(Rectangle.NO_BORDER);
			table.addCell(emptyCell);
		}
		
		document.add(table);
		document.close();
		file.close();
	}

}
