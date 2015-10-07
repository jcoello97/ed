package org.institutoserpis.ed;

import java.util.Scanner;

public class HolaMundo
{
	public static void main(String[] args) 
	{
		System.out.print("Introduce tu nombre: ");
		Scanner entrada = new Scanner(System.in);
		String nombre;
		nombre = entrada.next();
		System.out.printf("¡Hola %s desde eclipse!", nombre);
	
	}
	
}
