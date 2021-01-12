import { ViceCreateRequest } from "./ViceCreateRequest";

export class CandidatoCreateRequest{
  nome!: string;
  partidoId!: number;
  idade!: number;
  posicao!: string;
  foto!: string;
  vice!: ViceCreateRequest;
}