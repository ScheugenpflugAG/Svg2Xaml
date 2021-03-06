﻿using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Svg2Xaml;

namespace Svg2XamlTest
{

  //****************************************************************************
  public partial class MainWindow 
    : Window
  {
    //==========================================================================
    private readonly string FileName = "test10.svg";

    //==========================================================================
    public MainWindow()
    {
      InitializeComponent();

      using(FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read))
        //try
        {
          Image.Source = SvgReader.Load(stream);
        }
      /*
        catch(Exception exception)
        {
          TextBlock error_text_block = new TextBlock();
          error_text_block.Text = exception.Message;
          Content = error_text_block;
        }
       * */
    }

  } // class MainWindow
}
