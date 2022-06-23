<template>
    <v-speed-dial
      v-model="fab"
      fixed right bottom>
    >
      <template v-slot:activator>
        <v-btn  v-model="fab"  color="blue darken-2" dark  fab >
          <v-icon v-if="fab">
            mdi-close
          </v-icon>
          <v-icon v-else>
            mdi-cog 
          </v-icon>
        </v-btn>
      </template>
      <v-btn fab dark small color="green" >
        <v-icon>mdi-content-save </v-icon>
      </v-btn>
      <v-btn fab  dark small color="red"  >
        <v-icon>mdi-close-octagon </v-icon>
      </v-btn>
    </v-speed-dial>
    
</template>
<script>
  export default {
    data: () => ({
      direction: 'top',
      fab: false,
      fling: false,
      hover: false,
      tabs: null,
      top: false,
      right: true,
      bottom: true,
      left: false,
     // transition: 'slide-y-reverse-transition',
    }),

    watch: {
      top (val) {
        this.bottom = !val
      },
      right (val) {
        this.left = !val
      },
      bottom (val) {
        this.top = !val
      },
      left (val) {
        this.right = !val
      },
    },
  }
</script>
<style>
  /* This is for documentation purposes and will not be needed in your application */
  #create .v-speed-dial {
    position: absolute;
  }

  #create .v-btn--floating {
    position: relative;
  }
</style>