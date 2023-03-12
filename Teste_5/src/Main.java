import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		char n;
		String palavra;
		
		Scanner ler = new Scanner(System.in);

		System.out.println("Informe uma palavra: ");
		palavra = ler.next();
	
		for(int i = palavra.length(); i > 0; i--) {
			n = palavra.charAt(i-1);
			System.out.print(n);
		}
	}

}
