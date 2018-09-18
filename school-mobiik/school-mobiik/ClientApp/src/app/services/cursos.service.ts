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

  getCurso(idx:string) {
    this.cursos[idx];
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
};
