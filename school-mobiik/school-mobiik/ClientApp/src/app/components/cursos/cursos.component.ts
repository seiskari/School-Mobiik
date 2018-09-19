import { Component, OnInit } from '@angular/core';
import { CursosService, Curso } from '../../services/cursos.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-cursos',
  templateUrl: './cursos.component.html'
})
export class CursosComponent implements OnInit {
  cursos: Curso[] = [];

  constructor(private _cursosService: CursosService,
              private router:Router) { }

  ngOnInit() {
    this.cursos = this._cursosService.getCursos();
    console.log(this.cursos);
  }
  verCurso(idx: number) {
    this.router.navigate(['/course', idx]);
  }
  buscarCursos(termino: string) {
    console.log(termino);
    this.router.navigate(['/buscar', termino]);
  }


}
