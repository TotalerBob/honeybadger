<script>
	import Nav from '../components/Nav.svelte';

	export let segment;
</script>

<style>
	main {
		box-sizing: border-box;
	}
</style>


{#if false }
<Nav {segment}/>
{/if}

<main>
	<slot></slot>
</main>