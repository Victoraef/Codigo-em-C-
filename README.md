# Codigo-em-C++
#include<stdio.h>
#include<stdlib.h>

int main (){
	
	int pessoa;
	float valor;
	int opcao;
	float rateio;
	float valormulta;
	float multa2;
	
	
	printf("Digite quantidade de pessoa: ");
	scanf("%d",&pessoa);
	
	printf("Digite o valor da conta: ");
	scanf("%f",&valor);
	
	printf("\n\nTem multa? (digite o numero da opcao)\n");
	printf("1.Sim\n");
	printf("2.Nao");
	printf("\nOpcao: ");
	scanf("%d",&opcao);
	
	rateio = valor/pessoa;
	
	if (opcao == 1){
		printf("\nValor da multa: ");
		scanf("%f",&valormulta);
		
		multa2 = (valor + valormulta)/pessoa;
		
		printf("\n\nValor da conta com a multa: %.2f",multa2);
			
	} else {
		printf("Valor da conta: %.2f",rateio);
	}
	
	return 0;
}
