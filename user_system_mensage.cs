using System;
using System.Runtime.InteropServices;

public class Program
{
...
private static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
} 
