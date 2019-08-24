<script>
import { createEventDispatcher } from 'svelte';
const dispatch = createEventDispatcher();

export let selectedVoucher = 0;




let vouchers = [
  {
    voucher: {
      imgUrl: "",
    },
    deliveryNote: {
      imgUrl: "",
    }
  }
];


generateVouchers();

function generateVouchers(){
  let _vouchers = [];
  for(var i = 0; i < 30; i ++){
    _vouchers.push({
      id:i,
      voucher: {
        imgUrl: "voucher_01.png"
      },
      deliveryNote : {
        imgUrl : "delivery_note_01.png",
      },
    })
  }
  vouchers = _vouchers;
}

function handleClick(i){
selectedVoucher = i;

		dispatch('select', {
			voucher: vouchers[i],
		});
}

</script>


<style type="text/css">
.vouchers {
  display:flex;
  align-items:flex-start;
  flex-flow:row;
  overflow:scroll;  
  max-height:100px;  
}
  .voucher {
    position: relative;
    width:50px;
    height:50px;
    margin:10px;
    border-radius:5px;
    padding:5px;
    border:1px solid #d3d3d3;
    flex:none;
    overflow:hidden;
    cursor: pointer;
    box-sizing:border-box;
  }
  .voucher__active {
    border: 2px dashed #9d9d9d;
    box-shadow: 0 1px 5px rgba(0, 0, 0, 0.25);
  }

  .voucher__index {
    position: absolute;
    right: 0px;
    bottom: 0px;
    padding: 3px;
    color: #535353;
    background: #e8e8e8;
    border-radius: 5px 0 0 0;
    font-size: 12px;

  }


  .voucher_img {
    width:100%;
    height:auto;
  }
</style>


<div class="vouchers">  

{#each vouchers as voucher, i}
  <div class="voucher" class:voucher__active={selectedVoucher == i} on:click={()=>{handleClick(i)}}>
   <div class="voucher__index">#{i}</div>
    <img class="voucher_img" alt="" src={`documents/${voucher.voucher.imgUrl}`} />
  </div>
{/each}

</div>