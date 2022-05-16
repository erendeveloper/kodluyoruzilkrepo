import { storage, Context } from "near-sdk-as"
import { Game } from "./model"

export function add(name:string, price:u32):void{
  Game.add(name,price);
}
export function getPriceByName(name:string):u32{
  return Game.getPriceByName(name);
}
export function deleteByName(name:string):void{
  Game.deleteByName(name);
}