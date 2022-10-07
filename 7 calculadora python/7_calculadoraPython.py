# -*- coding: utf-8 -*-
"""
Created on Tue Oct  4 21:29:21 2022

@author: david
"""
def sumadora ( a, b):
        return a+b
def restadora (a,b):
        return a-b
def multiplicadora (a,b):
        return a*b
def divisora (a,b):
        return a/b        
n1 = float(input("Ingrese el primer numero: "))
n2 = float(input("Ingrese el primer numero: "))

print("la suma es: ",sumadora(n1,n2))
print("la resta es: ", restadora(n1,n2))
print("la multiplicacion es: ", multiplicadora(n1,n2))
print("la division es: ", divisora(n1,n2))