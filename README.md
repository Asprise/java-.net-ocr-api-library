Asprise Java/C#,VB.NET OCR and Barcode Recognition SDK
=========================

[Asprise Java/C#,VB.NET OCR (optical character recognition) and barcode recognition SDK](http://asprise.com/royalty-free-library/ocr-api-for-java-csharp-vb.net.html) offers a high performance API library for you to equip your
[Java applications (Java applets, web applications, Swing/JavaFX components, JEE enterprise applications)](http://asprise.com/royalty-free-library/java-ocr-api-overview.html)
as well as [C#, VB.NET applications (Windows applications, Sliverlight, ASP.NET web service applications, ActiveX controls, etc.)](http://asprise.com/royalty-free-library/c%23-sharp.net-ocr-api-overview.html)
with functionality of extracting text and barcode information from scanned document images.

You can convert images (in various formats like JPEG, PNG, TIFF, PDF, etc.) into editable document formats (Word, XML, searchable PDF, etc.). With other offering like Asprise Image Scanning SDK (which captures documents from scanners), you can easily implement full document management solutions.

Source code of the sample applications has been published.

Please browse SOURCE CODE.

Note: you need download the dependency dlls from Asprise.com:
[Java OCR API Free Download](http://asprise.com/royalty-free-library/java-ocr-for-windows-mac-linux-download.html) |
[C#,VB.NET Library Free Download](http://asprise.com/royalty-free-library/c%23-sharp.net-ocr-for-windows-mac-linux-download.html)

## Sample Input/Output

####Input
<a href="http://asprise.com/ocr/img/test-dpi-300.png" target=_blank><img src="http://asprise.com/ocr/img/test-dpi-300.png" alt="Sample Input Image" width="160"/></a>

####Output (Searchable PDF)
The OCR engine supports the follow output formats: plain text, xml with coordinates and searchable PDF.
[Here is the searchable PDF output](http://asprise.com/ocr/img/asprise-ocr-api-library-sample-output.pdf)


## Quick Start

Programming with Asprise OCR is very straightforward. Below is the typical source code sample to recognize images.

###Java OCR

```java
import com.asprise.ocr.Ocr
...

Ocr.setUp(); // one time setup
Ocr ocr = new Ocr(); // create a new OCR engine
ocr.startEngine("eng", Ocr.SPEED_FASTEST); // English
String s = ocr.recognize(new File[] {new File("test.png")},
  Ocr.RECOGNIZE_TYPE_ALL, Ocr.OUTPUT_FORMAT_PLAINTEXT);
System.out.println("Result: " + s);
ocr.stopEngine();
```

For details, please refer to [Java OCR API Developer's Guide](http://asprise.com/royalty-free-library/java-ocr-barcode-reader-sdk-samples-docs.html)

###C#/VB.NET OCR

```java
import com.asprise.ocr.Ocr
...

Ocr.setUp(); // one time setup
Ocr ocr = new Ocr(); // create a new OCR engine
ocr.startEngine("eng", Ocr.SPEED_FASTEST); // English
String s = ocr.recognize(new File[] {new File("test.png")},
  Ocr.RECOGNIZE_TYPE_ALL, Ocr.OUTPUT_FORMAT_PLAINTEXT);
System.out.println("Result: " + s);
ocr.stopEngine();
```

For details, please refer to [C#/VB.NET OCR Library Developer's Guide](http://asprise.com/royalty-free-library/c%23-sharp.net-ocr-barcode-reader-sdk-samples-docs.html)

For other languages, e.g., [C/C++/Delphi OCR and Barcode Recognition on Windows/Linux/Mac OS X, please click here](http://asprise.com/royalty-free-library/c-c++-delphi-ocr-api-overview.html)


##Features of Asprise OCR


###Accurate Text Recognition
With enhanced image processing and text detection algorithms, Asprise OCR can easily recognize difficult documents of poor image quality. Parameters can be used to hint favoring accuracy over speed.

####High Speed OCR Engine
Asprise OCR uses optimized OCR engine to perform excellent recognition in short time. Speed can be further improved through multi-threading and optional GPU acceleration.

####20+ Languages Supported
Recognizes 20+ languages such as English, Spanish, French, German, Italian, Hungarian, Finnish, Swedish, Romanian, Polish, Malay, Arabic, Indonesian, and Russian.

####All Popular Barcode Formats
All popular barcode formats are supported: EAN-8, EAN-13, UPC-A, UPC-E, ISBN-10, ISBN-13, Interleaved 2 of 5, Code 39, Code 128, PDF417, and QR Code.

####Images To Searchable PDF
With a few lines of code, you can convert various formats of images such as JPEG, PNG, TIFF, and PDF into searchable PDF files.

####Easy Deployment
No software protection dongle, no licensing server required. Deployment of Asprise OCR SDK is as easy as you develop with it.

####Budget Friendly, Royalty-Free
Royalty-free means you pay when you order a development license, but you don't have to pay again when you deploy your software to thousands of servers or to thousands of end users.
