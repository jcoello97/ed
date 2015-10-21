package org.institutoserpis.ed;

import java.util.Vector;

import javax.swing.text.AbstractDocument.LeafElement;

public class Array 
{

	public static void main(String[] args) 
	{
		int[] vector = new int[]{5, 9, 7, 12, 21};
		
		for(int index = 0; index < vector.length; index++)
			System.out.println("Elemento con index="+index+" vale "+vector[index]);
		
		
		System.out.println("suma del array "+ suma(vector));
		System.out.println("suma del array "+ suma(new int[]{20,15}));
		System.out.println("suma del array "+ suma(new int[]{}));
		System.out.println("el valor menor de v es: "+ menor(vector));
	}

	public static int suma(int[] v)
	{
		// numero de elementos del vector: v.lenght
		int sumador = 0;
		for(int index = 0; index < v.length; index++)
				sumador = sumador + v[index];
		return sumador;
	}
	
	public static int menor(int[] v)
	{
		int menor = v[0];
		for(int index = 1; index < v.length; index++)
			if(v[index]<menor)
				menor= v[index];				
		return menor;
	}

}
