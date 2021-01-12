import { Partido } from "./Partido";
import { Vice } from "./Vice";

export class Candidato{
  id!: number;
  nome!: string;
  partido!: Partido;
  idade!: number;
  posicao!: string;
  foto!: string;
  vice!: Vice;
}