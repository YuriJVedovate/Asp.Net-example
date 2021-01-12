import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { CandidatosService } from 'src/app/services/candidatos.service';

@Component({
  selector: 'app-dialogo-delete-candidato',
  templateUrl: './dialogo-delete-candidato.component.html',
  styleUrls: ['./dialogo-delete-candidato.component.css']
})
export class DialogoDeleteCandidatoComponent implements OnInit {

  constructor(private rest: CandidatosService,
    public dialogRef: MatDialogRef<DialogoDeleteCandidatoComponent>) { }

  ngOnInit(): void {
  }

  verificar(deletar: boolean){
    this.dialogRef.close(deletar);
  }
}
