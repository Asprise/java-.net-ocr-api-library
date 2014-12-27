package com.asprise.ocr;
// Created on: 12-04-2014 4:25 PM

import org.junit.BeforeClass;
import org.junit.Ignore;
import org.junit.Test;

import java.io.File;
import java.util.Arrays;
import java.util.Properties;

/**
 *
 */
public class OcrTest {

    @Test
    public void testMicr() {
        Ocr.setUp();
        System.out.println("Langs: " + Arrays.toString(Ocr.listSupportedLanguages()));
        Ocr ocr = new Ocr();
        ocr.startEngine("micr", Ocr.SPEED_FASTEST);
        System.out.println("OCR started.");

        long timeStart = System.currentTimeMillis();
        String s = ocr.recognize(new File[] {
                new File("micr.jpg")}, Ocr.RECOGNIZE_TYPE_TEXT, Ocr.OUTPUT_FORMAT_PLAINTEXT);
        long timeTaken = System.currentTimeMillis() - timeStart;

        System.out.println("--- RESULT ---");
        System.out.println(s);
        System.out.println("--- Time taken: " + (timeTaken / 1000.0) + "s ---");
        System.out.println("Langs: " + Arrays.toString(Ocr.listSupportedLanguages()));

        ocr.stopEngine();
        System.out.println("OCR stopped.");
        System.out.println("Langs: " + Arrays.toString(Ocr.listSupportedLanguages()));

    }

    @Test @Ignore
    public void testPdfOutput() {
        final String inputFile = "test-300dpi-bw.png";
        Ocr.setUp();
        Ocr ocr = new Ocr();
        ocr.startEngine("eng", Ocr.SPEED_FASTEST);
        System.out.println("OCR in progress, please stand by ...");
        long timeStart = System.currentTimeMillis();
        Properties props = new Properties();
        props.setProperty(Ocr.PROP_PDF_OUTPUT_FILE, "out.pdf");
        props.setProperty(Ocr.PROP_PDF_OUTPUT_TEXT_VISIBLE, Boolean.TRUE.toString());
        String s = ocr.recognize(new File[] {new File(inputFile), new File(inputFile)}, Ocr.RECOGNIZE_TYPE_ALL,
                Ocr.OUTPUT_FORMAT_XML,
                props);
        long timeTaken = System.currentTimeMillis() - timeStart;
        ocr.stopEngine();
        System.out.println("--- RESULT ---");
        System.out.println(s);
        System.out.println("--- Time taken: " + (timeTaken / 1000.0) + "s ---");
    }

    @Test
    public void dummy() {
    }
}
