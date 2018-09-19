import { Component, Input } from '@angular/core';
import { CursosService, Curso } from '../../services/cursos.service';

import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-curso',
  templateUrl: './curso.component.html'
})
export class CursoComponent {
  curso: any[] = [];
  constructor(private activatedRoute: ActivatedRoute,
    private _cursosService: CursosService) {

    this.activatedRoute.params.subscribe(params => {
      this.curso = this._cursosService.getCurso(params['id']);
      console.log(params['id']);
      console.log(this.curso);
    });
  }


}
