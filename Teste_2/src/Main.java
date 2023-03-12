import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
int a = 0, b = 1, aux = 0;
		
		Scanner ler = new Scanner(System.in);
		int numero = 0;
		
		System.out.println("Informe um número para saber se faz parte da série de fibonacci ");
	    System.out.print("Número: ");
	    numero = ler.nextInt();
	    
	    if(numero == 0) System.out.println("PERTENCE a sequência.");
		if(numero < 0) System.out.println("NÃO PERTENCE a sequência.");
	    
	    for(;numero != a && a < numero;) {
	    	aux = b + a;
	        a = b;
	        b = aux;
	        System.out.println(a);
	        if (numero == a) {
	        	System.out.println("PERTENCE a sequência.");
	        }
	        if (a > numero) {
	        	System.out.println("NÃO pertence a sequência.");
	        }
	    }

	}

}
