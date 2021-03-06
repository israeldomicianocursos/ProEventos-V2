import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
//import { threadId } from 'node:worker_threads';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  larguraImagem: number = 80;
  margemImagem: number = 2;
  mostrarImagem: boolean = true;
  filtroLista: string = '';

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  alterarImagem() {
    this.mostrarImagem = !this.mostrarImagem;
  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );
  }

}
