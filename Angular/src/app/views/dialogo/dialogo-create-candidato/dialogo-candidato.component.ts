import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { CandidatoCreateRequest } from 'src/app/models/request/CandidatoCreateRequest';
import { CandidatosService } from 'src/app/services/candidatos.service';

@Component({
  selector: 'app-dialogo-candidato',
  templateUrl: './dialogo-candidato.component.html',
  styleUrls: ['./dialogo-candidato.component.css']
})
export class DialogoCandidatoComponent implements OnInit {

  public candidatoForm!: FormGroup;

  public requestCandidato!: CandidatoCreateRequest;

  constructor(private fb: FormBuilder,
    private rest: CandidatosService,
    public dialogRef: MatDialogRef<DialogoCandidatoComponent>) { }

  ngOnInit(): void {
    this.candidatoForm = this.fb.group({
      nome: ['', [Validators.required]],
      partidoId: ['', [Validators.required]],
      idade: ['', [Validators.required]],
      posicao: ['', [Validators.required]],
      foto: ['', [Validators.required]],
      viceId: [1],
      viceNome: ['', [Validators.required]],
      vicePartidoId: [1],
      vicePartidoNome: ['string'],
      vicePartidoNumero: [1],
      viceFoto: ['', [Validators.required]],
      viceIdade: ['', [Validators.required]]
    });
  }

  cancelar(): void {
    this.dialogRef.close();
    this.candidatoForm.reset();
  }

  criarCandidato() {
    this.requestCandidato = {
      nome: this.candidatoForm.value.nome,
      partidoId: parseInt(this.candidatoForm.value.partidoId),
      idade: parseInt(this.candidatoForm.value.idade),
      posicao: this.candidatoForm.value.posicao,
      foto: this.candidatoForm.value.foto,
      vice: {
        id: this.candidatoForm.value.viceId,
        nome: this.candidatoForm.value.viceNome,
        partidoId: this.candidatoForm.value.vicePartidoId,
        nomePartido: this.candidatoForm.value.vicePartidoNome,
        numeroEleitoral: this.candidatoForm.value.vicePartidoNumero,
        foto: this.candidatoForm.value.viceFoto,
        idade: parseInt(this.candidatoForm.value.viceIdade)
      }
    };

    this.rest.postCandidato(this.requestCandidato).subscribe(result => { });
    this.dialogRef.close();
    this.candidatoForm.reset();
    window.location.reload();
  }
}
