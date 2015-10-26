package org.institutoserpis.ed;

import java.util.Vector;

import javax.swing.text.AbstractDocument.LeafElement;

public class Array 
{

	public static void main(String[] args) 
	{
		int[] v = new int[]{5, 9, 7, 12, 21};
		
		for(int index = 0; index < v.length; index++)
			System.out.println("Elemento con index="+index+" vale "+v[index]);
		
		
		System.out.println("suma del array "+ suma(v));
		System.out.println("suma del array "+ suma(new int[]{20,15}));
		System.out.println("suma del array "+ suma(new int[]{}));
		System.out.println("el valor menor de v es: "+ menor(v));
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
	
	public static int indexOf(int[] v, int item)
	{
		int index=0;
		while(index<v.length && v[index]!=item)
			index++;
		
		if(index==v.length)	//Index ha llegado al maximo de v.length y no ha enocntrado el valor.
			return -1;	//por convenio se pone -1 cuando no encuentra el valor en el array.
		else
			return index;	//si no es asi, es xk se ha encontrado el valor dentro de v.length
							//Y se devuelve index con ese respectivo valor dentro de v.length
	}

}
