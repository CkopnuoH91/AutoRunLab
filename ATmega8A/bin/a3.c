/*****************************************************
��������� ���������������� ATmega8� ��� ������ ��� 
����������������� ��������
�����������: �������� ������ ���������� 2014�.
���������� ����������:
���.: +375259994711
e-mail: ckopnuoh_victor@mail.ru
*****************************************************/

#include <mega8.h>
#include <string.h>
#include <delay.h>
#include <stdlib.h>
#include <stdio.h>

unsigned int read_adc(unsigned char adc_input);
void DiodeAI(int Imax, int Sign);
void DiodeAU(int Umax, int Sign);
void DiodeBI(int Imax, int Sign);
void DiodeBI1(int Imax, int Sign);
char k;
const int delay = 5; 
static char buf[10];
static int  i = 0;
char num[10];

// ������� ���������� �������1 �� ������������
interrupt [TIM1_OVF] void timer1_ovf_isr(void)
{
int t;

if(UCSRA.7)  
{
   k = getchar();
   buf[i] = k;
   i++;    
   if(k == 'x')
   { 
       i = 0;
       t =  atoi(strncpy(num,buf + 1,4));       
       switch (buf[0]) 
       {
          case '1' :         
           PORTD.6 = 0;
           delay_ms(500);
           TCCR1A = 0b10000001;   
           printf("%d;%d\r\n", 0, 0);                        
           DiodeAI(t*100, 1); 
           TCCR1A = 0b00000001;           
          break;
          
          case '2' :
           PORTD.6 = 1;
           delay_ms(500);
           TCCR1A = 0b10000001; 
           printf("%d;%d\r\n", 0, 0);                       
           DiodeAI(t*100,-1);
           TCCR1A = 0b00000001;  
          break;
                     
          case '3' : 
           PORTD.6 = 0;
           delay_ms(500);
           TCCR1A = 0b10000001;   
           printf("%d;%d\r\n", 0, 0);                        
           DiodeAI(t*100, 1); 
           PORTD.6 = 1; 
           printf("%d;%d\r\n", 0, 0);           
           DiodeAI(t*100,-1);
           TCCR1A = 0b00000001;                   
          break;
          
          case '4' : 
           PORTD.6 = 0;
           PORTD.7 = 0;
           delay_ms(500);
           TCCR1A = 0b10000001;
           DiodeAU(t*10,1);
           TCCR1A = 0b10100001;
           printf("%d;%d\r\n", 0, 0);
           DiodeBI(10000,1);          
           TCCR1A = 0b00000001;       
          break;   
           
          case '5' :    
           PORTD.6 = 0;
           PORTD.7 = 0;
           delay_ms(500);         
           TCCR1A = 0b00100001;
           DiodeBI1(t*10,1);
           TCCR1A = 0b10100001;
           printf("%d;%d\r\n", 0, 0);
           DiodeAI(10000,1);
           TCCR1A = 0b00000001;               
          break;
                            
          case '6' : 
           PORTD.6 = 1;
           PORTD.7 = 1;
           delay_ms(500);
           TCCR1A = 0b10000001;
           DiodeAU(t*10,1);
           TCCR1A = 0b10100001;
           printf("%d;%d\r\n", 0, 0);
           DiodeBI(10000,1);          
           TCCR1A = 0b00000001;            
          break;
          
          case '7' : 
           PORTD.6 = 1;
           PORTD.7 = 1;
           delay_ms(500);         
           TCCR1A = 0b00100001;
           DiodeBI1(t*10,1);
           TCCR1A = 0b10100001;
           printf("%d;%d\r\n", 0, 0);
           DiodeAI(10000,1);
           TCCR1A = 0b00000001;         
          break;
         
        default: 
             printf("%s", buf); 
             buf[0]='';
             buf[1]='';                    
       };  
       buf[0]='';
       buf[1]='';          
   }
}
}

#define ADC_VREF_TYPE 0x00

// ������� ��� ��������� �����������
unsigned int read_adc(unsigned char adc_input)
{
  ADMUX=adc_input | (ADC_VREF_TYPE & 0xff);
  delay_us(10);
  ADCSRA|=0x40;
  while ((ADCSRA & 0x10)==0);
  ADCSRA|=0x10;
  return ADCW;
}

// ������� ��� ���������� ��������� �� ������ �
void DiodeAI(int Imax, int Sign)
{
  for(OCR1A = 0; OCR1A < 255; OCR1A++)
  {
    int U,I;   
    delay_ms(delay);  
    
    U = read_adc(0)*4.887*2;
    I = (read_adc(1)*4.887*2 - U); 
    
    printf("%d;%d\r\n", U*Sign, abs(I)*Sign);
    if(I > Imax) 
     {           
       break;
     }    
  }  
};

// ������� ��� ���������� ��������� �� ������ �
void DiodeBI(int Imax, int Sign)
{
 for(OCR1B = 0; OCR1B < 255; OCR1B++) 
 {
    int U,I;   
    delay_ms(delay);  
    
    U = read_adc(2)*4.887*2;
    I = (read_adc(3)*4.887*2 - U); 
    
    printf("%d;%d\r\n", U*Sign, abs(I)*Sign);
    if(I > Imax) 
    { 
      break;
    }       
 } 
};

// ������� ������������ ������� ���������� �� ������ � 
void DiodeAU(int Umax, int Sign)
{
 for(OCR1A = 0; OCR1A < 255; OCR1A++)
 {
   int U;   
   delay_ms(delay);  
    
   U = read_adc(0)*4.887*2;   
   if(U > Umax) 
   { 
     printf("%d\r\n", U*Sign); 
     break;
   }      
 } 
};

// ������� ������������ ������� ���� �� ������ � 
void DiodeBI1(int Imax, int Sign)
{
 for(OCR1B = 0; OCR1B < 255; OCR1B++) 
 {
    int U,I;   
    delay_ms(delay);  
    
    U = read_adc(2)*4.887*2;
    I = (read_adc(3)*4.887*2 - U); 
     
    if(I > Imax) 
    {  
      printf("%d\r\n", abs(I)*Sign);
      break;
    }  
 } 
};


void main(void)
{
// ������������� ����� �
PORTB=0x00;
DDRB=0x06;

// ������������� ����� �
PORTC=0x00;
DDRC=0x00;

// ������������� ����� D
PORTD=0x00;
DDRD=0b11000000;

// ������������� �������0
TCCR0=0x00;
TCNT0=0x00;

// ������������� �������1
// �������� ������������: ���������� ���������
// �������: 8 ���
// �����: Fast PWM top=0x00FF
TCCR1A = 0b00000001;
TCCR1B=0x89;
TCNT1H=0x00;
TCNT1L=0x00;
ICR1H=0x00;
ICR1L=0x00;
OCR1AH=0x00;
OCR1AL=0x00;
OCR1BH=0x00;
OCR1BL=0x00;
OCR1A=0;

// ������������� �������1
ASSR=0x00;
TCCR2=0x00;
TCNT2=0x00;
OCR2=0x00;

// ������� ����������
MCUCR=0x00;

TIMSK=0x04;

// ������������� USART
// ���������: 8 ��� ������, 1 ���� ���, ��� �������� ��������
// USART ��������: �������
// USART ����������: �������
// ����� USART: �����������
// �������� ��������: 9600 ���
UCSRA=0x00;
UCSRB=0x18;
UCSRC=0x86;
UBRRH=0x00;
UBRRL=0x33;

// ������������� ����������� �����������
// ���������� ����������: ��������
ACSR=0x80;
SFIOR=0x00;

// ������������� ���
// ������� ������������ ���: 62,5 kHz
// �������� �������� ����������: AREF
ADMUX=ADC_VREF_TYPE & 0xff;
ADCSRA=0b10000111;

// ������������� SPI
// SPI ��������
SPCR=0x00;

// ������������� TWI
// TWI ��������
TWCR=0x00;

// ��������� ���������� ����������
#asm("sei")

 while (1)
 {
    #asm("sleep");       
 }
}
