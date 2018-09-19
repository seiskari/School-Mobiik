import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CursosService {
  private cursos: Curso[] = [
    {
      CourseId: "Esp361",
      SignaturesId: 1,
      SchoolId: "e1",
      TeacherId: 2,
      MinToPass: 8,
      Year: 2018,
      Credits: 9,
      StarDate: "20130803",
      EndDate: "20180301",
      IsActive: true,
      ScheduleId: 1,
    },

    {
      CourseId: "Esp362",
      SignaturesId: 1,
      SchoolId: "b1",
      TeacherId: 2,
      MinToPass: 8,
      Year: 2018,
      Credits: 9,
      StarDate: "20130803",
      EndDate: "20180301",
      IsActive: true,
      ScheduleId: 1,
    }
  ];

    constructor() {
      console.log("Servicio listo para usar.")
    }

  getCursos(): Curso[] {
    return this.cursos;
  }

  getCurso(idx:number):any {
    this.cursos[idx];
  }

  buscarHeroes(termino: string): Curso[] {

    let cursosArr: Curso[] = [];
    termino = termino.toLowerCase();

    for (let i = 0; i < this.cursos.length; i++) {

      let curso = this.cursos[i];

      let nombre = curso.CourseId.toLowerCase();

      if (nombre.indexOf(termino) >= 0) {
        curso.idx = i;
        cursosArr.push(curso)
      }

    }

    return cursosArr;

  }


}



export interface Curso {
  CourseId: string;
  SignaturesId: number;
  SchoolId: string;
  TeacherId: number;
  MinToPass?: number;
  Year: number;
  Credits?: number;
  StarDate: string;
  EndDate: string;
  IsActive: boolean;
  ScheduleId: number;
  idx?: number;
};
