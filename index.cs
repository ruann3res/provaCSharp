using System;
using System.Collections.Generic;

class Pilha {
  private Stack<string> pecas = new Stack<string>();

  public void Empilhar(string peca) {
    pecas.Push(peca);
  }

  public void TrocarPeca(string pecaAntiga, string pecaNova) {
    Stack<string> temporario = new Stack<string>();
    bool pecaEncontrada = false;

    while (pecas.Count > 0) {
      string peca = pecas.Pop();

      if (!pecaEncontrada) {
        if (peca == pecaAntiga) {
          pecaEncontrada = true;
          temporario.Push(pecaNova);
        } else {
          temporario.Push(peca);
        }
      } else {
        temporario.Push(peca);
      }
    }

    while (temporario.Count > 0) {
      pecas.Push(temporario.Pop());
    }
  }
}
