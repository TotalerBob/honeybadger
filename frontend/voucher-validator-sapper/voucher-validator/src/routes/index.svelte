<script>
import Vouchers from "../components/Voucher/Vouchers.svelte";
import VoucherView from "../components/Voucher/VoucherView.svelte";

let selectedVoucher = null;

function handleSelectVoucher(evt){
	selectedVoucher = evt.detail.voucher;
}

</script>

<style>

</style>

<svelte:head>
	<title>Voucher Validation</title>
</svelte:head>

<div>
<Vouchers on:select={handleSelectVoucher}></Vouchers>
<VoucherView voucher={selectedVoucher}></VoucherView>
</div>
