# NEAR Protocol- Game Shop Example


Game Shop project for NEAR Protocol.
Template copied from "github.com/learn-NEAR/starter--near-sdk-as"

# Instructions

```
near-login
```

if near-cli not installed

```
npm install --global near-cli
```

```
cd game-shop-project
yarn

yarn build:release
near dev-deploy ./build/release/simple.wasm
export CONTRACT=<YOUR_ACCOUNT_ID>

```

# Game class
  ```
  name:string
  price:u32
  ```


# Functions

add

```
near call $CONTRACT add '{"name":"<name>","price":"<peice>","price":<Price>}' --accountId <your_account>.testnet
```

get price by name

```
near view $CONTRACT getPriceByName '{"name":<name>}' --accountId <your_account>.testnet
```

delete by name
```
near call $CONTRACT delete '{"name":<name>}' --accountId <your_account>.testnet
```
