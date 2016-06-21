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

// Boost
struct  Boost_t64369539  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.Collider2D Boost::target
	Collider2D_t1890038195 * ___target_2;
	// System.Single Boost::boostspeed
	float ___boostspeed_3;
	// System.Single Boost::normalspeed
	float ___normalspeed_4;

public:
	inline static int32_t get_offset_of_target_2() { return static_cast<int32_t>(offsetof(Boost_t64369539, ___target_2)); }
	inline Collider2D_t1890038195 * get_target_2() const { return ___target_2; }
	inline Collider2D_t1890038195 ** get_address_of_target_2() { return &___target_2; }
	inline void set_target_2(Collider2D_t1890038195 * value)
	{
		___target_2 = value;
		Il2CppCodeGenWriteBarrier(&___target_2, value);
	}

	inline static int32_t get_offset_of_boostspeed_3() { return static_cast<int32_t>(offsetof(Boost_t64369539, ___boostspeed_3)); }
	inline float get_boostspeed_3() const { return ___boostspeed_3; }
	inline float* get_address_of_boostspeed_3() { return &___boostspeed_3; }
	inline void set_boostspeed_3(float value)
	{
		___boostspeed_3 = value;
	}

	inline static int32_t get_offset_of_normalspeed_4() { return static_cast<int32_t>(offsetof(Boost_t64369539, ___normalspeed_4)); }
	inline float get_normalspeed_4() const { return ___normalspeed_4; }
	inline float* get_address_of_normalspeed_4() { return &___normalspeed_4; }
	inline void set_normalspeed_4(float value)
	{
		___normalspeed_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
