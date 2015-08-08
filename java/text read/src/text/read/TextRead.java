/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package text.read;

import java.io.*;
/**
 *
 * @author ahmadhalah
 */
public class TextRead {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        String file_name="C:\\Users\\ahmadhalah\\Desktop\\Text.txt";      
        Readfile file=new Readfile(file_name);
        String[] aryLines=file.OpenFile( );
        
        for(int i=0;i<aryLines.length;i++)
            System.out.println(aryLines[i]);
        
      
      
        
       
              
        
    }
    
}
