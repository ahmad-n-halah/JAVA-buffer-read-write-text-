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
 class Readfile {
    
    private final String path;
    
    public Readfile(String file_path){
        path=file_path;
    }
    
     public String[] OpenFile(){
         
        int lines=3;
        String[] textData=new String[lines];
        
        try{
        FileReader fr= new FileReader(path);
        BufferedReader textReader= new BufferedReader(fr);
        
        
        for(int i=0;i<lines;i++)
            textData[i]=textReader.readLine();
            
          textReader.close();
        }
        catch(IOException e){
            System.out.print(e.getMessage());
        }
        

                       return textData;
 }
 }

