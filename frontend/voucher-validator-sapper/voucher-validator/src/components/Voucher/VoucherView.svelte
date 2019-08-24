<script>

let voucherImg = "voucher_01.png";
let deliveryNoteImg = "delivery_note_01.png";

export let voucher;

</script>


<style>
.voucher_detail {
  width:80%;
  margin:0 auto;
  display:flex;
}

.voucher_detail_view {
  display:flex;
  justify-content:center;
  width: 50%;
  margin:20px;
  padding:20px;
  height:calc(100vh - 250px);
  border-radius:5px;
  border: 1px solid #d3d3d3;
}

.voucher_detail_view img {
  max-height:100%;
  max-width:100%;
}

.voucher_title {
  margin-top:15px;
  font-size:20px; 
  text-align:center;
}
</style>

{#if voucher}
<div class="voucher_title">
Voucher #{voucher.id}
</div>
<div class="voucher_detail">

  <div class="voucher_detail_view voucher_detail_view__left">
    <img src={`documents/${voucher.voucher.imgUrl}`} alt=""/>
  </div>
  <div class="voucher_detail_view voucher_detail_view__right">
    <img src={`documents/${voucher.deliveryNote.imgUrl}`} alt=""/>
  </div>
</div>
{/if}