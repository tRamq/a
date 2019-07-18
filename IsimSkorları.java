package isimskorları;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.Scanner;

public class IsimSkorları {
    public static void main(String[] args){
        int toplam =  0;
        String buyukToplam = "";
        char []alfabe = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        try(Scanner scanner =new Scanner(new BufferedReader( new FileReader("kayıt.txt")))){
             while(scanner.hasNextLine()){
                 String kisiler = scanner.nextLine();
                 String []kisiDizisi = null;
                 kisiDizisi = kisiler.split(",");
                 
                 for (int i = 0; i < kisiDizisi.length; i++) {
                     for (int j = 0; j < kisiDizisi.length; j++) {
                         String temp = "";
                         if ((int)kisiDizisi[i].charAt(1) < (int)kisiDizisi[j].charAt(1)) {
                             temp = kisiDizisi[i];
                             kisiDizisi[i] = kisiDizisi[j];
                             kisiDizisi[j] = temp; 
                         }
                         else if ((int)kisiDizisi[i].charAt(1) == (int)kisiDizisi[j].charAt(1) && (int)kisiDizisi[i].charAt(2) < (int)kisiDizisi[j].charAt(2)) {
                             temp = kisiDizisi[i];
                             kisiDizisi[i] = kisiDizisi[j];
                             kisiDizisi[j] = temp; 
                         }
                         else if ((int)kisiDizisi[i].charAt(1) == (int)kisiDizisi[j].charAt(1) && (int)kisiDizisi[i].charAt(2) == (int)kisiDizisi[j].charAt(2) && (int)kisiDizisi[i].charAt(3) < (int)kisiDizisi[j].charAt(3) ) {
                             if ((int)kisiDizisi[i].charAt(3) == '"') {
                                 break;
                             }
                             temp = kisiDizisi[i];
                             kisiDizisi[i] = kisiDizisi[j];
                             kisiDizisi[j] = temp; 
                         }
                         else if ((int)kisiDizisi[i].charAt(1) == (int)kisiDizisi[j].charAt(1) && (int)kisiDizisi[i].charAt(2) == (int)kisiDizisi[j].charAt(2) && (int)kisiDizisi[i].charAt(3) == (int)kisiDizisi[j].charAt(3) && (int)kisiDizisi[i].charAt(4) < (int)kisiDizisi[j].charAt(4)) {
                             if ((int)kisiDizisi[i].charAt(3) == '"' || (int)kisiDizisi[i].charAt(4) == '"') {
                                 break;
                             }
                             temp = kisiDizisi[i];
                             kisiDizisi[i] = kisiDizisi[j];
                             kisiDizisi[j] = temp; 
                         }
                         else if ((int)kisiDizisi[i].charAt(1) == (int)kisiDizisi[j].charAt(1) && (int)kisiDizisi[i].charAt(2) == (int)kisiDizisi[j].charAt(2) && (int)kisiDizisi[i].charAt(3) == (int)kisiDizisi[j].charAt(3) && (int)kisiDizisi[i].charAt(4) == (int)kisiDizisi[j].charAt(4) && (int)kisiDizisi[i].charAt(4) < (int)kisiDizisi[j].charAt(4)) {
                             if ((int)kisiDizisi[i].charAt(3) == '"' || (int)kisiDizisi[i].charAt(4) == '"' || (int)kisiDizisi[i].charAt(5) == '"') {
                                 break;
                             }
                             temp = kisiDizisi[i];
                             kisiDizisi[i] = kisiDizisi[j];
                             kisiDizisi[j] = temp; 
                         }
                         
                     }
                 }
                 String []dizi ={"ARIF", "AKIF", "COLIN"};
                 for (int i = 0; i < kisiDizisi.length; i++) {
                     toplam = 0;
                     for (int j = 0; j < alfabe.length; j++) {
                         for (int k = 0; k < kisiDizisi[i].length(); k++) {
                             if (kisiDizisi[i].charAt(k) != '"' && kisiDizisi[i].charAt(k) == alfabe[j]) {
                                  toplam += (j + 1);
                                  
                             }
                         }
                     }
                     System.out.println((i + 1) + " " + kisiDizisi[i] + " " + toplam);
                     buyukToplam += (i + 1) * toplam;
                     
                 }
                 System.out.println("Isım skorlari toplami:  " + buyukToplam);
             }
        }catch (FileNotFoundException ex) {
            System.out.println("Dosya Bulunamadi  ");
        }
    }
    
}
