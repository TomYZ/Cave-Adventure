#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Collider2D
struct Collider2D_t1890038195;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// healthUp
struct  healthUp_t3187533335  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.Collider2D healthUp::target
	Collider2D_t1890038195 * ___target_2;

public:
	inline static int32_t get_offset_of_target_2() { return static_cast<int32_t>(offsetof(healthUp_t3187533335, ___target_2)); }
	inline Collider2D_t1890038195 * get_target_2() const { return ___target_2; }
	inline Collider2D_t1890038195 ** get_address_of_target_2() { return &___target_2; }
	inline void set_target_2(Collider2D_t1890038195 * value)
	{
		___target_2 = value;
		Il2CppCodeGenWriteBarrier(&___target_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
