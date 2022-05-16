import {PersistentMap} from "near-sdk-as";

const games = new PersistentMap<string, Game>("games");

@nearBindgen
export class Game {
  name: string;
  price: u32;

  constructor(name: string, price:u32) {
    this.name = name;
    this.price = price;
  }

  static add(name: string, price:u32):void{
    const game = new Game(name,price);
    games.set(game.name, game); 
  }
  static getPriceByName(name:string): u32 {
    let game = games.getSome(name)
    return game.price;
  }
  static deleteByName(name:string): void {
    games.delete(name);
  }
}