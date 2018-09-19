import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CursosService } from '../../services/cursos.service'

@Component({
  selector: 'app-buscar-cursos',
  templateUrl: './buscar-cursos.component.html'
})
export class BuscarCursosComponent implements OnInit {
  curso: any[] = [];
  termino: string;
  constructor(private activatedRoute: ActivatedRoute,
              private _cursosService: CursosService) { }

  ngOnInit() {
    this.activatedRoute.params.subscribe(params => {
      this.termino = params['termino'];
      this.curso = this._cursosService.buscarCursos(params['termino']);
      console.log(this.curso);
    })
  }

}
