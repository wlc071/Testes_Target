public class Main {

	public static void main(String[] args) {
		
		String[] estados = {"SP","RJ","MG","ES","Outros"};
		Double[] valores = {67836.43, 36678.66, 29229.88, 27165.48, 19849.53};
		
		double totalV = 0;
		
		for (int i =0; i < valores.length; i++) {
			totalV += valores[i];
		}
		
		for(int i=0; i < estados.length; i++) {
			System.out.println("["+estados[i]+"]: "+ (valores[i]/totalV));
		}
		
	}
}
