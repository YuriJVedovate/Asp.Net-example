import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { PartidosService } from 'src/app/services/partidos.service';

@Component({
  selector: 'app-dialogo-delete-partido',
  templateUrl: './dialogo-delete-partido.component.html',
  styleUrls: ['./dialogo-delete-partido.component.css']
})
export class DialogoDeletePartidoComponent implements OnInit {

  constructor(private rest: PartidosService,
    public dialogRef: MatDialogRef<DialogoDeletePartidoComponent>) { }

  ngOnInit(): void {
  }

  verificar(deletar: boolean){
    this.dialogRef.close(deletar);
  }
}
