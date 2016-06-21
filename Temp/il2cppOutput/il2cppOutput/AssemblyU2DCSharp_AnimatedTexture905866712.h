#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"
#include "UnityEngine_UnityEngine_Vector23525329788.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// AnimatedTexture
struct  AnimatedTexture_t905866712  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.Vector2 AnimatedTexture::speed
	Vector2_t3525329788  ___speed_2;

public:
	inline static int32_t get_offset_of_speed_2() { return static_cast<int32_t>(offsetof(AnimatedTexture_t905866712, ___speed_2)); }
	inline Vector2_t3525329788  get_speed_2() const { return ___speed_2; }
	inline Vector2_t3525329788 * get_address_of_speed_2() { return &___speed_2; }
	inline void set_speed_2(Vector2_t3525329788  value)
	{
		___speed_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
