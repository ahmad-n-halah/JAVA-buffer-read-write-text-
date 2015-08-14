/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication22;
import java.io.BufferedReader;;
import java.io.FileReader;
import java.io.IOException;

import java.io.FileWriter;
import java.io.PrintWriter;
/**
 *
 * @author ahmadhalah
 */
public class JavaApplication22 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
//Input        
        String line;
	try(BufferedReader br=new BufferedReader(new FileReader("C:\\Users\\ahmadhalah\\Desktop\\Text.txt"))){
            while((line=br.readLine())!=null){
                System.out.println(line);
            }
            br.close();
//Output
            FileWriter write=new FileWriter("C:\\Users\\ahmadhalah\\Desktop\\Text.txt",true);
            PrintWriter print_line=new PrintWriter(write);
            print_line.printf("%s"+"%n",";ljk;;k");
            print_line.close();

            
            
            
            
        }catch(IOException e){
            e.getMessage();
        }
    }
   
}