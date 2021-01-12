import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Candidato } from 'src/app/models/Candidato';
import { Partido } from 'src/app/models/Partido';
import { CandidatosService } from 'src/app/services/candidatos.service';
import { PartidosService } from 'src/app/services/partidos.service';
import { DialogoCandidatoComponent } from '../dialogo/dialogo-create-candidato/dialogo-candidato.component';
import { DialogoPartidoComponent } from '../dialogo/dialogo-create-partido/dialogo-partido.component';
import { DialogoDeleteCandidatoComponent } from '../dialogo/dialogo-delete-candidato/dialogo-delete-candidato.component';

@Component({
  selector: 'app-eleicao',
  templateUrl: './eleicao.component.html',
  styleUrls: ['./eleicao.component.css']
})
export class EleicaoComponent implements OnInit {

  candidatos!: Candidato[];
  partidos!: Partido[];

  loadCandidados: boolean = false;
  loadPartidos: boolean = false;

  constructor(public candidatosService: CandidatosService,
    public partidosService: PartidosService,
    public dialog: MatDialog) { }

  ngOnInit() {
    this.carregarCandidatos();
    this.carregarPartidos();
  }

  addCandidato(): void {
    const dialogRef = this.dialog.open(DialogoCandidatoComponent, {
      minWidth: '600px',
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
  
  addPartido(): void {
    const dialogRef = this.dialog.open(DialogoPartidoComponent, {
      minWidth: '600px',
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

  deleteCandidato(id: number){
    console.log(id);

    const dialogRef = this.dialog.open(DialogoDeleteCandidatoComponent, {
      minWidth: '300px',
    });

    dialogRef.afterClosed().subscribe(result => {
      if(result){
        this.candidatosService.deleteCandidato(id).subscribe(result =>{
          window.location.reload();
        });
      }
      console.log('The dialog was closed');
    });

  }

  carregarCandidatos() {
    this.candidatosService.getAllCandidatos().subscribe(data => {
      this.candidatos = data.itens;
      console.log(this.candidatos);
      this.loadCandidados = true;
    });
  }

  carregarPartidos() {
    this.partidosService.getAllPartidos().subscribe(data => {
      this.partidos = data.itens;
      console.log(this.partidos);
      this.loadPartidos =  true;
    })

  }

}

