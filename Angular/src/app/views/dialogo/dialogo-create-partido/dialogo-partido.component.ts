import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { PartidoCreateRequest } from 'src/app/models/request/PartidoCreateRequest';
import { PartidosService } from 'src/app/services/partidos.service';

@Component({
  selector: 'app-dialogo-partido',
  templateUrl: './dialogo-partido.component.html',
  styleUrls: ['./dialogo-partido.component.css']
})
export class DialogoPartidoComponent implements OnInit {

  public partidoForm!: FormGroup;
  public requestPartido!: PartidoCreateRequest;

  constructor(private fb: FormBuilder,
    private rest: PartidosService,
    public dialogRef: MatDialogRef<DialogoPartidoComponent>) { }

  ngOnInit(): void {
    this.partidoForm = this.fb.group({
      "nome": ['', [Validators.required]],
      "sigla": ['', [Validators.required]],
      "numeroEleitoral": [ , [Validators.required]],
      "foto": ['', [Validators.required]]
    });
  }

  cancelar(): void {
    this.dialogRef.close();
    this.partidoForm.reset();
  }

  criarPartido() {
    this.requestPartido = {
      namePartido: this.partidoForm.value.nome,
      siglaPartido: this.partidoForm.value.sigla,
      numeroEleitoral: parseInt(this.partidoForm.value.numeroEleitoral),
      foto: this.partidoForm.value.foto
    }

    this.rest.postPartido(this.requestPartido).subscribe(result => { });
    this.dialogRef.close();
    this.partidoForm.reset();
    window.location.reload();
  }
}
