using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// API for Asprise OCR C#/VB.NET SDK. Visit http://asprise.com/product/ocr for more details.
namespace asprise_ocr_api
{
    /// <summary>
    /// Represents an Asprise OCR engine.
    /// API for Asprise OCR C#/VB.NET SDK. Visit http://asprise.com/product/ocr for more details.
    /// </summary>
    public class AspriseOCR
    {
        private const string OCR_DLL_NAME_32 = "aocr.dll";
        private const string OCR_DLL_NAME_64 = "aocr_x64.dll";

        /** Highest speed, accuracy may suffer - default option */
        public const String SPEED_FASTEST           = "fastest";
        /** less speed, better accuracy */
        public const String SPEED_FAST              = "fast";
        /** lowest speed, best accuracy */
        public const String SPEED_SLOW              = "slow";

        /** Recognize  text */
        public const String RECOGNIZE_TYPE_TEXT     = "text";
        /** Recognize barcode */
        public const String RECOGNIZE_TYPE_BARCODE  = "barcode";
        /** Recognize both text and barcode */
        public const String RECOGNIZE_TYPE_ALL      = "all";

        /** Output recognition result as plain text */
        public const String OUTPUT_FORMAT_PLAINTEXT = "text";
        /** Output recognition result in XML format with additional information if coordination, confidence, runtime, etc. */
        public const String OUTPUT_FORMAT_XML       = "xml";
        /** Output recognition result as searchable PDF */
        public const String OUTPUT_FORMAT_PDF       = "pdf";

        /** Languages */
        /** eng (English) */
        public const String LANGUAGE_ENG = "eng";
        /** spa (Spanish) */
        public const String LANGUAGE_SPA = "spa";
        /** por (Portuguese) */
        public const String LANGUAGE_POR = "por";
        /** deu (German) */
        public const String LANGUAGE_DEU = "deu";
        /** fra (French) */
        public const String LANGUAGE_FRA = "fra";

        // ------------------------ general options ------------------------
        /** Recognition level. Optional. Valid values: multi (multi-line, default), single, word */
        public const String PROP_BLOCK_LEVEL     = "PROP_BLOCK_LEVEL"; // char/symbol level performs very poor.

        /** Whether empty blocks should be returned. Optional. Valid values: false (default), true. */
        public const String PROP_INCLUDE_EMPTY_BLOCK = "PROP_INCLUDE_EMPTY_BLOCK";

        // ------------------------ PDF specific ------------------------
        /** PDF output file - required for PDF output. Valid prop value: absolute path to the target output file. */
        public const String PROP_PDF_OUTPUT_FILE         = "PROP_PDF_OUTPUT_FILE";
        /** The DPI of the images or '0' to auto-detect. Optional. Valid prop value: 0(default: auto-detect), 300, 200, etc. */
        public const String PROP_PDF_OUTPUT_IMAGE_DPI           = "PROP_PDF_OUTPUT_IMAGE_DPI";

        /** Font to be used for PDF output. Optional. Valid values: "serif" (default), "sans". */
        public const String PROP_PDF_OUTPUT_FONT = "PROP_PDF_OUTPUT_FONT";

        /** Make text visible - for debugging and analysis purpose. Optional. Valid prop values false(default), true. */
        public const String PROP_PDF_OUTPUT_TEXT_VISIBLE  = "PROP_PDF_OUTPUT_TEXT_VISIBLE";

        /** Convert images into black/white to reduce PDF output file size. Optional. Valid prop values: false(default), true.*/
        public const String PROP_PDF_OUTPUT_IMAGE_FORCE_BW= "PROP_PDF_OUTPUT_IMAGE_FORCE_BW";

        /** Do not change unless you are told so. */
        public static String CONFIG_PROP_SEPARATOR = "|";
        /** Do not change unless you are told so. */
        public static String CONFIG_PROP_KEY_VALUE_SEPARATOR = "=";

        /** Recognize all pages. */
        public const int PAGES_ALL = -1;

        /// <summary>
        /// Unmanaged code access (32bit).
        /// </summary>
        private static class OcrDll32
        {
            [DllImport(OCR_DLL_NAME_32, CharSet = CharSet.Ansi)]
            public static extern IntPtr com_asprise_ocr_version();

            [DllImport(OCR_DLL_NAME_32, CharSet = CharSet.Ansi)]
            public static extern int com_asprise_ocr_setup(int queryOnly);

            [DllImport(OCR_DLL_NAME_32, CharSet = CharSet.Ansi)]
            public static extern IntPtr com_asprise_ocr_start(string lang, string speed);

            [DllImport(OCR_DLL_NAME_32, CharSet = CharSet.Ansi)]
            public static extern void com_asprise_ocr_stop(Int64 handle);

            [DllImport(OCR_DLL_NAME_32, EntryPoint = "com_asprise_ocr_recognize")]
            public static extern IntPtr com_asprise_ocr_recognize(Int64 handle, string imgFiles, int pageIndex, int startX, int startY, int width, int height, string recognizeType, string outputFormat, string propSpec, string propSeparator, string propKeyValueSpeparator);

            [DllImport(OCR_DLL_NAME_32, CharSet = CharSet.Ansi)]
            public static extern void com_asprise_ocr_input_license(string licenseeName, string licenseCode);

            [DllImport(OCR_DLL_NAME_32, CharSet = CharSet.Ansi)]
            public static extern void com_asprise_ocr_util_delete(Int64 handle, bool isArray);
        }

        /// <summary>
        /// Unmanaged code access (64bit).
        /// </summary>
        private static class OcrDll64
        {
            [DllImport(OCR_DLL_NAME_64, CharSet = CharSet.Ansi)]
            public static extern IntPtr com_asprise_ocr_version();

            [DllImport(OCR_DLL_NAME_64, CharSet = CharSet.Ansi)]
            public static extern int com_asprise_ocr_setup(int queryOnly);

            [DllImport(OCR_DLL_NAME_64, CharSet = CharSet.Ansi)]
            public static extern IntPtr com_asprise_ocr_start(string lang, string speed);

            [DllImport(OCR_DLL_NAME_64, CharSet = CharSet.Ansi)]
            public static extern void com_asprise_ocr_stop(Int64 handle);

            [DllImport(OCR_DLL_NAME_64, CharSet = CharSet.Ansi)]
            public static extern IntPtr com_asprise_ocr_recognize(Int64 handle, string imgFiles, int pageIndex, int startX, int startY, int width, int height, string recognizeType, string outputFormat, string propSpec, string propSeparator, string propKeyValueSpeparator);

            [DllImport(OCR_DLL_NAME_64, CharSet = CharSet.Ansi)]
            public static extern void com_asprise_ocr_input_license(string licenseeName, string licenseCode);

            [DllImport(OCR_DLL_NAME_64, CharSet = CharSet.Ansi)]
            public static extern void com_asprise_ocr_util_delete(Int64 handle, bool isArray);
        }

        private IntPtr _handle = new IntPtr(0);

        /// <summary>
        /// Whether the OCR engine is currently running.
        /// </summary>
        public bool IsEngineRunning {
            get { return _handle.ToInt64() > 0;}
        }

        /// <summary>
        /// Starts the OCR engine; does nothing if the engine has already been started.
        /// </summary>
        /// <param name="lang">e.g., "eng"</param>
        /// <param name="speed">e.g., "fastest"</param>
        public void StartEngine(string lang, string speed)
        {
            if (IsEngineRunning)
            {
                return;
            }
            if (lang == null || speed == null || lang.Trim().Length == 0 || speed.Trim().Length == 0)
            {
                throw new Exception("Invalid arguments.");
            }

            _handle = Is64BitProcess ? 
                OcrDll64.com_asprise_ocr_start(lang, speed) :
                OcrDll32.com_asprise_ocr_start(lang, speed);

            if (_handle.ToInt64() < 0)
            {
                _handle = new IntPtr(0);
                throw new Exception("Failed to start engine. Error code: " + _handle.ToInt64());
            }
        }

        /// <summary>
        /// Stops the OCR engine; does nothing if it has already been stopped.
        /// </summary>
        public void StopEngine()
        {
            if (!IsEngineRunning)
            {
                return;
            }
            if (Is64BitProcess)
            {
                OcrDll64.com_asprise_ocr_stop(_handle.ToInt64());
            }
            else
            {
                OcrDll32.com_asprise_ocr_stop(_handle.ToInt64());
            }
        }

        private Thread threadDoingOCR;

        /// <summary>
        /// Performs OCR on the given input files.
        /// </summary>
        /// <param name="files">comma ',' separated image file path (JPEG, BMP, PNG, TIFF)</param>
        /// <param name="pageIndex">-1 for all pages or the specified page (first page is 1) for multi-page image format like TIFF</param>
        /// <param name="startX">-1 for whole page or the starting x coordinate of the specified region</param>
        /// <param name="startY">-1 for whole page or the starting y coordinate of the specified region</param>
        /// <param name="width">-1 for whole page or the width of the specified region</param>
        /// <param name="height">-1 for whole page or the height of the specified region</param>
        /// <param name="recognizeType">valid values: RECOGNIZE_TYPE_TEXT, RECOGNIZE_TYPE_BARCODE or RECOGNIZE_TYPE_ALL.</param>
        /// <param name="outputFormat">valid values: OUTPUT_FORMAT_PLAINTEXT or OUTPUT_FORMAT_XML.</param>
        /// <param name="additionalProperties">additional properties, can be a single Dictionary object or inline specification in pairs. Valid property names are defined in this class, e.g., PROP_INCLUDE_EMPTY_BLOCK, etc.</param>
        /// <returns>text (plain text, xml) recognized for OUTPUT_FORMAT_PLAINTEXT, OUTPUT_FORMAT_XML; empty for OUTPUT_FORMAT_PDF.</returns>
    public string Recognize(string files, int pageIndex, int startX, int startY, int width, int height, string recognizeType, string outputFormat, params object[] additionalProperties)
    {
        if (threadDoingOCR != null)
        {
            throw new Exception("Currently " + threadDoingOCR + " is using this OCR engine. Please create multiple OCR engine instances for multi-threading. ");
        }

        Dictionary<string, string> dict = new Dictionary<string, string>();

        if(additionalProperties != null && additionalProperties.Length > 0 && 
            (additionalProperties[0] as Dictionary<string, string> != null))
        {
            foreach (KeyValuePair<string, string> pair in (Dictionary<string, string>)additionalProperties[0])
            {
                if (pair.Key != null)
                {
                    dict.Add(pair.Key.ToString(), pair.Value == null ? null : pair.Value.ToString());
                }
            }
        } else if(additionalProperties != null && additionalProperties.Length > 0) {
            if (additionalProperties.Length%2 == 1)
            {
                throw new Exception("You must specify additional properties in key/value pair. Current length: " + additionalProperties.Length);
            }
            for (var p = 0; p < additionalProperties.Length; p += 2)
            {
                string key = (string) additionalProperties[p];
                object val = additionalProperties[p + 1];
                if (key != null)
                {
                    dict.Add(key, val == null ? "" : val.ToString());
                }
            }
        }

        // validation 
        foreach (KeyValuePair<string, string> pair in dict)
        {
            if (pair.Key.Contains(CONFIG_PROP_KEY_VALUE_SEPARATOR))
            {
                throw new Exception("Please change CONFIG_PROP_KEY_VALUE_SEPARATOR to a different value as \"" +
                    pair.Key + "\" contains \"" + CONFIG_PROP_KEY_VALUE_SEPARATOR + "\"");
            }
            if (pair.Value.Contains(CONFIG_PROP_SEPARATOR))
            {
                throw new Exception("Please change CONFIG_PROP_SEPARATOR to a different value as \"" +
                        pair.Value + "\" contains \"" + CONFIG_PROP_SEPARATOR + "\"");
            }
        }

        if (outputFormat.Equals(OUTPUT_FORMAT_PDF))
        {
            string pdfOutputFile = dict.ContainsKey(PROP_PDF_OUTPUT_FILE) ? dict[PROP_PDF_OUTPUT_FILE] : null;
            if (pdfOutputFile == null)
            {
                throw new Exception("You must specify PDF output through property named: " + PROP_PDF_OUTPUT_FILE);
            }
        }

        try
        {
            threadDoingOCR = Thread.CurrentThread;

            IntPtr ptr = (Is64BitProcess ? 
                OcrDll64.com_asprise_ocr_recognize(_handle.ToInt64(), files, pageIndex, startX, startY, width, height, recognizeType, outputFormat, dictsToString(dict), CONFIG_PROP_SEPARATOR, CONFIG_PROP_KEY_VALUE_SEPARATOR) :
                OcrDll32.com_asprise_ocr_recognize(_handle.ToInt64(), files, pageIndex, startX, startY, width, height, recognizeType, outputFormat, dictsToString(dict), CONFIG_PROP_SEPARATOR, CONFIG_PROP_KEY_VALUE_SEPARATOR)
            );

            string s = Marshal.PtrToStringAnsi(ptr);
            if (s != null && s.Length > 0 && ptr.ToInt64() > 0)
            {
                // clean up
                deleteC(ptr, true);
            }
            return s;
        }
        finally
        {
            threadDoingOCR = null;
        }

    }

    /// <summary>
    /// The library version.
    /// </summary>
    /// <returns>The library version.</returns>
    public static string GetLibraryVersion()
    {
        return Marshal.PtrToStringAnsi(Is64BitProcess ? 
            OcrDll64.com_asprise_ocr_version() : 
            OcrDll32.com_asprise_ocr_version());
    }

    /// <summary>
    /// Performs one-time setup; does nothing if setup has already been done.
    /// </summary>
    public static void SetUp()
    {
        if (Is64BitProcess)
        {
            OcrDll64.com_asprise_ocr_setup(0);
        }
        else
        {
            OcrDll32.com_asprise_ocr_setup(0);
        }
    }

    public static void InputLicense(string licenseeName, string licenseCode)
    {
        if (Is64BitProcess)
        {
            OcrDll64.com_asprise_ocr_input_license(licenseeName, licenseCode);
        }
    }

    /// <summary>
    /// Search PATH and return the location of the ocr dll.
    /// </summary>
    /// <returns></returns>
    public static string getOcrDllPath()
    {
        return searchFileInPath(getOcrDllName());
    }

    /// <summary>
    /// The simple name of the ocr dll file.
    /// </summary>
    /// <returns></returns>
    public static string getOcrDllName()
    {
        return Is64BitProcess ? OCR_DLL_NAME_64 : OCR_DLL_NAME_32;
    }

    /// <summary>
    /// Search the ancester directories and return the directory that contains ocr dll or null if not found.
    /// </summary>
    /// <returns></returns>
    public static string detectOcrDllInParentFolders()
    {
        string folder = AppDomain.CurrentDomain.BaseDirectory;
        while (true)
        {
            if (File.Exists(Path.Combine(folder, getOcrDllName())))
            {
                return folder;
            }
            else
            {
                folder = Path.GetDirectoryName(folder);
                if (folder == null)
                {
                    break;
                }
            }
        }
        return null;
    }

    /// <summary>
    /// Returns the absolute path of the first occurrence
    /// </summary>
    /// <param name="fileSimpleName"></param>
    /// <returns></returns>
    public static string searchFileInPath(string fileSimpleName)
    {

        string path = getSystemPath();
        string[] folders = path.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
        // insert current dir to folders
        string[] extended = new string[folders.Length + 1];
        extended[0] = Directory.GetCurrentDirectory();
        Array.Copy(folders, 0, extended, 1, folders.Length);
        folders = extended;
        for (int i = 0; i < folders.Length; i++)
        {
            string folder = folders[i];
            folder = folder.Replace('/', '\\');
            if (!folder.EndsWith("\\"))
            {
                folder += "\\";
            }
            string file = folder + fileSimpleName;
            if (File.Exists(file))
            {
                return file;
            }
        }
        return null;
    }

    private static bool Is64BitProcess
    {
        get { return IntPtr.Size == 8; }
    }

    private static void deleteC(IntPtr ptr, bool isArray)
    {
        if (Is64BitProcess)
        {
            OcrDll64.com_asprise_ocr_util_delete(ptr.ToInt64(), isArray);
        }
        else
        {
            OcrDll32.com_asprise_ocr_util_delete(ptr.ToInt64(), isArray);
        }
    }

    private static string getSystemPath()
    {
        return Environment.GetEnvironmentVariable("PATH");
    }

    /// <summary>
    /// Adds the given directory to the PATH variable.
    /// </summary>
    /// <param name="dir"></param>
    public static void addToSystemPath(string dir)
    {
        Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + dir);
    }

    private static string dictsToString(Dictionary<string, string> dict)
    {
        StringBuilder sb = new StringBuilder();
        foreach (KeyValuePair<string, string> pair in dict)
        {
            if (sb.Length > 0)
            {
                sb.Append(CONFIG_PROP_SEPARATOR);
            }
            sb.Append(pair.Key);
            sb.Append(CONFIG_PROP_KEY_VALUE_SEPARATOR);
            sb.Append(pair.Value);
        }
        return sb.ToString();
    }

    /// <summary>
    /// Returns the ToString() for non-null object or ""/"null" for null.
    /// </summary>
    /// <param name="obj">target object</param>
    /// <param name="nullAsEmpty">true to return "" for null; false "null"</param>
    /// <returns></returns>
    public static string objectToString(object obj, bool nullAsEmpty = true)
    {
        if (obj == null)
        {
            return nullAsEmpty ? "" : "null";
        }
        return obj.ToString();
    }
    
    /// <summary>
    /// Returns the first non-null object or null if all arguments are null.
    /// </summary>
    /// <param name="o"></param>
    /// <param name="others"></param>
    /// <returns></returns>
    public static object firstNonNull(object o, params object[] others)
    {
        if (o != null)
        {
            return o;
        }

        for (var i = 0; others != null && i < others.Length; i++)
        {
            if (others[i] != null)
            {
                return others[i];
            }
        }

        return null;
    }

        public static bool isEmpty(string s)
        {
            return s == null || s.Trim().Length == 0;
        }


    }
}
